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
    /// Interaction logic for Data_Layanan.xaml
    /// </summary>
    public partial class Data_Layanan : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static Data_Layanan menu;
        public static DataGrid dataGrid;
        void terkunci()
        {
            mnLogin.IsEnabled = false;
            mnObatLama.IsEnabled = false;
            menu = this;
        }
        public Data_Layanan()
        {
            InitializeComponent();
            terkunci();
            Load();
        }

        private void Load()
        {
            tabel_layanan.ItemsSource = db.Obats.ToList();
            dataGrid = tabel_layanan;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow aPage = new MainWindow();
            aPage.Show();
            this.Close();
        }

        private void mnPasienLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Pasien exist_Pasien = new Data_Pasien();
            exist_Pasien.Show();
            this.Close();
        }

        private void mnPasienBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Pasien np = new Tambah_Pasien();
            np.Show();
            this.Close();
        }

        private void mnDokterLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Dokter dd = new Data_Dokter();
            dd.Show();
            this.Close();
        }

        private void mnDokterBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Dokter td = new Tambah_Dokter();
            td.Show();
            this.Close();
        }

        private void mnObatBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Layanan ao = new Tambah_Layanan();
            ao.Show();
            this.Close();
        }

        private void mnTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Transaksi tr = new Transaksi();
            tr.Show();
            this.Close();
        }

        private void mnTransaksi_Click_1(object sender, RoutedEventArgs e)
        {
            Riwayat r = new Riwayat();
            r.Show();
            this.Close();
        }
        private void GridDoctors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Obat d = (Obat)this.tabel_layanan.SelectedItems[0];
            kode.Text = d.kode_obat;
            nama.Text = d.nama_obat;
            harga.Text = d.harga.ToString();

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var r = from d in db.Obats
                    where d.kode_obat == kode.Text
                    select d;

            Obat obj = r.SingleOrDefault();

            if (obj != null)
            {
                obj.nama_obat = nama.Text;
                obj.harga = int.Parse(harga.Text);

                db.SaveChanges();
                dataGrid.Items.Refresh();
            }
        }
    }
}

