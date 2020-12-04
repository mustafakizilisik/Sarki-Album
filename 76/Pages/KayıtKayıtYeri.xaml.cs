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
    /// Interaction logic for KayıtKayıtYeri.xaml
    /// </summary>
    public partial class KayıtKayıtYeri : Page
    {
        string sorgu;
        SqlCommand komut;
        DataRowView seçili;
        public KayıtKayıtYeri()
        {
            InitializeComponent();
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

        public KayıtKayıtYeri(DataRowView drv)
        {
            InitializeComponent();

            seçili = drv;

            tbKayıtYeriAdı.Text = seçili["KayıtYeriAdı"].ToString();
            imgResim.Source = seçili["Resim"].ToString().Length == 0
                ? imgResim.Source
                : Bağla.ByteArraytoBitmapSource((byte[])seçili["Resim"]);
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (seçili == null)
            {
                sorgu = "INSERT INTO [KayıtYerleri] VALUES (@Resim,@KayıtYeriAdı)";
                komut = new SqlCommand(sorgu, Bağla.conn);
            }
            else
            {

                sorgu = "UPDATE [KayıtYerleri] SET KayıtYeriAdı=@KayıtYeriAdı,Resim=@Resim WHERE Id=@Id";
                komut = new SqlCommand(sorgu, Bağla.conn);
                komut.Parameters.AddWithValue("@Id", seçili["Id"]);
            }
            komut.Parameters.AddWithValue("@KayıtYeriAdı", tbKayıtYeriAdı.Text);
            komut.Parameters.AddWithValue("@Resim", Bağla.BitmapSourcetoByteArray((BitmapSource)imgResim.Source));
            
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
                    NavigationService.Navigate(new Uri("Pages/ListeleKayıtYeri.xaml", UriKind.Relative));
                }
            }
        }
    }
}
