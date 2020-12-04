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
    /// Interaction logic for KayıtŞarkıcı.xaml
    /// </summary>
    public partial class KayıtŞarkıcı : Page
    {
        string sorgu;
        SqlCommand komut;
        DataRowView seçili;
        public KayıtŞarkıcı()
        {
            InitializeComponent();
        }

        public KayıtŞarkıcı(DataRowView drv)
        {
            InitializeComponent();

            seçili = drv;

            tbŞarkıcıAdı.Text = seçili["Ad"].ToString();
            tbŞarkıcıSoyadı.Text = seçili["Soyad"].ToString();
            dpDoğumTarihi.Text = seçili["DoğumTarihi"].ToString();
            tbÜlke.Text = seçili["Ülke"].ToString();
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (seçili == null)
            {
                sorgu = "INSERT INTO [Şarkıcılar] VALUES (@Ad,@Soyad,@DoğumTarihi,@Ülke)";
                komut = new SqlCommand(sorgu, Bağla.conn);
            }
            else
            {

                sorgu = "UPDATE [Şarkıcılar] SET Ad=@Ad,Soyad=@Soyad,DoğumTarihi=@DoğumTarihi,Ülke=@Ülke WHERE Id=@Id";
                komut = new SqlCommand(sorgu, Bağla.conn);
                komut.Parameters.AddWithValue("@Id", seçili["Id"]);
            }
            komut.Parameters.AddWithValue("@Ad", tbŞarkıcıAdı.Text);
            komut.Parameters.AddWithValue("@Soyad", tbŞarkıcıSoyadı.Text);
            komut.Parameters.AddWithValue("@DoğumTarihi", dpDoğumTarihi.SelectedDate);
            komut.Parameters.AddWithValue("@Ülke", tbÜlke.Text);


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
                    NavigationService.Navigate(new Uri("Pages/ListeleŞarkıcı.xaml", UriKind.Relative));
                }
            }
        }
    }
}
