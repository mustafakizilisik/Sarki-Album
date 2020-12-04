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
    /// Interaction logic for KayıtAlbümŞarkı.xaml
    /// </summary>
    public partial class KayıtAlbümŞarkı : Page
    {
        string sorgu;
        SqlCommand komut;
        DataRowView seçili;
        public KayıtAlbümŞarkı()
        {
            InitializeComponent();
            cbAlbümAdı.ItemsSource = Bağla.Listele("SELECT * FROM [Albümler]");
            cbŞarkıAdı.ItemsSource = Bağla.Listele("SELECT * FROM [Şarkılar]");
        }

        public KayıtAlbümŞarkı(DataRowView drv)
        {
            InitializeComponent();
            tbŞarkıUzunluğu.Text = seçili["ŞarkıUzunluğu"].ToString();
            cbŞarkıAdı.SelectedValue = (DateTime)seçili["ŞarkıAdı"];
            cbAlbümAdı.SelectedValue = seçili["AlbümAdı"].ToString();
            
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (seçili == null)
            {
                sorgu = "INSERT INTO [AlbümŞarkıları] VALUES (@ŞarkıUzunluğu,@ŞarkıAdı,@AlbümAdı)";
                komut = new SqlCommand(sorgu, Bağla.conn);
            }
            else
            {

                sorgu = "UPDATE [AlbümŞarkıları] SET ŞarkıUzunluğu=@ŞarkıUzunluğu,ŞarkıAdı=@ŞarkıAdı,AlbümAdı=@AlbümAdı WHERE Id=@Id";
                komut = new SqlCommand(sorgu, Bağla.conn);
                komut.Parameters.AddWithValue("@Id", seçili["Id"]);
            }
            komut.Parameters.AddWithValue("@ŞarkıUzunluğu", tbŞarkıUzunluğu.Text);
            komut.Parameters.AddWithValue("@ŞarkıAdı", cbŞarkıAdı.SelectedValue);
            komut.Parameters.AddWithValue("@AlbümAdı", cbAlbümAdı.SelectedValue);

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
                    NavigationService.Navigate(new Uri("Pages/ListeleAlbümŞarkı.xaml", UriKind.Relative));
                }
            }
        }
    }
}
