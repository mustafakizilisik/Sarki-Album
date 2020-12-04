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
    /// Interaction logic for ListeleŞarkıcı.xaml
    /// </summary>
    public partial class ListeleŞarkıcı : Page
    {
        DataRowView seçili;
        string sorgu;
        SqlCommand komut;
        DataTable dt;
        public ListeleŞarkıcı()
        {
            InitializeComponent();
            dg.ItemsSource = Bağla.Listele("SELECT * FROM [Şarkıcılar]");
        }

        private void miSil_Click(object sender, RoutedEventArgs e)
        {
            if (dg.SelectedItem == null) return;
            var sonuc = MessageBox.Show("Kayıt Silinsin mi?", "Uyarı", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (sonuc == MessageBoxResult.Yes)
            {
                seçili = dg.SelectedItem as DataRowView;
                sorgu = "DELETE FROM [Şarkıcılar] WHERE Id=@Id";
                komut = new SqlCommand(sorgu, Bağla.conn);
                komut.Parameters.AddWithValue("@Id", seçili["Id"]);
                Bağla.Open();
                komut.ExecuteNonQuery();
                Bağla.Close();
                dg.ItemsSource = Bağla.Listele("SELECT * FROM [Şarkıcılar]");
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi.", "Uyarı", MessageBoxButton.OK);
            }
        }

        private void miGüncelle_Click(object sender, RoutedEventArgs e)
        {
            if (dg.SelectedItem == null) { return; }
            else
            {
                seçili = dg.SelectedItem as DataRowView;
                NavigationService.Navigate(new KayıtŞarkıcı(seçili));
            }
        }
    }
}
