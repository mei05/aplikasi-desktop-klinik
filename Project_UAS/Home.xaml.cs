using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Project_UAS
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static Home menu;
        void terbuka()
        {
            mnLogin.IsEnabled = false;
            mnPasien.IsEnabled = true;
            mnDokter.IsEnabled = true;
            mnObat.IsEnabled = true;
            mnTransaksi.IsEnabled = true;
            menu = this;
        }
        public Home()
        {
            InitializeComponent();
            terbuka();
        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow aPage = new MainWindow();
            aPage.Show();
            this.Close();
        }

        private void mnPasienLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Pasien p = new Data_Pasien();
            p.Show();
            this.Close();
        }

        private void mnPasienBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Pasien p = new Tambah_Pasien();
            p.Show();
            this.Close();
        }

        private void mnDokterLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Dokter p = new Data_Dokter();
            p.Show();
            this.Close();
        }

        private void mnDokterBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Dokter p = new Tambah_Dokter();
            p.Show();
            this.Close();
        }

        private void mnObatLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Layanan p = new Data_Layanan();
            p.Show();
            this.Close();
        }

        private void mnObatBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Layanan p = new Tambah_Layanan();
            p.Show();
            this.Close();
        }

        private void mnTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Transaksi p = new Transaksi();
            p.Show();
            this.Close();
        }

        private void mnHTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Riwayat p = new Riwayat();
            p.Show();
            this.Close();
        }
    }
}
