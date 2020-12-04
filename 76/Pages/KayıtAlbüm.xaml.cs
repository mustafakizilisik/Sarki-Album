using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _76.Pages
{
    /// <summary>
    /// Interaction logic for KayıtAlbüm.xaml
    /// </summary>
    public partial class KayıtAlbüm : Page
    {
        string sorgu;
        SqlCommand komut;
        DataRowView seçili;
        public KayıtAlbüm()
        {
            InitializeComponent();
            cbKayıtYeri.ItemsSource = Bağla.Listele("SELECT * FROM [KayıtYerleri]");
        }

        public KayıtAlbüm(DataRowView drv)
        {
            InitializeComponent();

            tbAlbümAd.Text = seçili["AlbümAdı"].ToString();
            dpAlbümYıl.SelectedDate = (DateTime)seçili["AlbümYılı"];
            cbKayıtYeri.SelectedValue = seçili["KayıtYeriAdı"].ToString();
            imgResim.Source = seçili["Resim"].ToString().Length == 0
                ? imgResim.Source
                : Bağla.ByteArraytoBitmapSource((byte[])seçili["Resim"]);
        }

        private void btnResimEkle_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Resim Seç...",
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;"
            };
            if (ofd.ShowDialog() == true)
            {
                imgResim.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (seçili == null)
            {
                sorgu = "INSERT INTO [Albümler] VALUES (@Resim,@AlbümAdı,@AlbümYılı,@KayıtYeriAdı)";
                komut = new SqlCommand(sorgu, Bağla.conn);
            }
            else
            {

                sorgu = "UPDATE [Albümler] SET Resim=@Resim,AlbümAdı=@AlbümAdı,AlbümYılı=@AlbümYılı,KayıtYeriAdı=@KayıtYeriAdı WHERE Id=@Id";
                komut = new SqlCommand(sorgu, Bağla.conn);
                komut.Parameters.AddWithValue("@Id", seçili["Id"]);
            }
            komut.Parameters.AddWithValue("@Resim", Bağla.BitmapSourcetoByteArray((BitmapSource)imgResim.Source));
            komut.Parameters.AddWithValue("@AlbümAdı", tbAlbümAd.Text);
            komut.Parameters.AddWithValue("@KayıtYeriAdı", cbKayıtYeri.SelectedValue);
            komut.Parameters.AddWithValue("@AlbümYılı", dpAlbümYıl.SelectedDate);
            
            try
            {
                Bağla.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarılı!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if (Bağla.conn.State == ConnectionState.Open)
                {
                    Bağla.Close();
                    NavigationService.Navigate(new Uri("Pages/ListeleAlbüm.xaml", UriKind.Relative));
                }
            }
        }
    }
}
