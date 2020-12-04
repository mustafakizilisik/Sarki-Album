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
    /// Interaction logic for KayıtŞarkı.xaml
    /// </summary>
    public partial class KayıtŞarkı : Page
    {
        string sorgu;
        SqlCommand komut;
        DataRowView seçili;
        
        public KayıtŞarkı()
        {
            InitializeComponent();
            cbŞarkıcıAdı.ItemsSource = Bağla.Listele("SELECT * FROM [Şarkıcılar]");
        }

        public KayıtŞarkı(DataRowView drv)
        {
            InitializeComponent();

            tbŞarkıAdı.Text = seçili["ŞarkıAdı"].ToString();
            cbŞarkıcıAdı.SelectedValue = seçili["Ad"].ToString();
            
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (seçili == null)
            {
                sorgu = "INSERT INTO [Şarkılar] VALUES (@ŞarkıAdı,@Ad)";
                komut = new SqlCommand(sorgu, Bağla.conn);
            }
            else
            {

                sorgu = "UPDATE [Şarkılar] SET ŞarkıAdı=@ŞarkıAdı,Ad=@Ad WHERE Id=@Id";
                komut = new SqlCommand(sorgu, Bağla.conn);
                komut.Parameters.AddWithValue("@Id", seçili["Id"]);
            }
            komut.Parameters.AddWithValue("@ŞarkıAdı", tbŞarkıAdı.Text);
            komut.Parameters.AddWithValue("@Ad", cbŞarkıcıAdı.SelectedValue);

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
                    NavigationService.Navigate(new Uri("Pages/ListeleŞarkı.xaml", UriKind.Relative));
                }
            }
        }
    }
}
