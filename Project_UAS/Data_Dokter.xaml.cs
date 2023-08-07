using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for Data_Dokter.xaml
    /// </summary>
    public partial class Data_Dokter : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static Data_Dokter menu;
        public static DataGrid dataGrid;
        void terkunci()
        {
            mnLogin.IsEnabled = false;
            mnDokterLama.IsEnabled = false;
            menu = this;
        }
        public Data_Dokter()
        {
            InitializeComponent();
            terkunci();
            Load();
            
        }

        private void Load()
        {
            tabel.ItemsSource = db.Dokters.ToList();
            dataGrid = tabel;
            
        }

        private void mnPasienLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Pasien ep = new Data_Pasien();
            ep.Show();
            this.Close();
        }

        private void mnPasienBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Pasien np = new Tambah_Pasien();
            np.Show();
            this.Close();
        }


        private void mnDokterBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Dokter td = new Tambah_Dokter();
            td.Show();
            this.Close();
        }

        private void mnObatLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Layanan dl = new Data_Layanan();
            dl.Show();
            this.Close();
        }

        private void mnObatBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Layanan dl = new Tambah_Layanan();
            dl.Show();
            this.Close();
        }

        private void mnTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Transaksi tr = new Transaksi();
            tr.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void mnHTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Riwayat r = new Riwayat();
            r.Show();
            this.Close();
        }
        private void GridDoctors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dokter d = (Dokter)this.tabel.SelectedItems[0];
            kode.Text = d.kode_dokter;
            nama.Text = d.nama_dokter;
            alamat.Text = d.alamat;
            no_telp.Text = d.no_telp;
            pendidikan.Text = d.pendidikan;
            spesialis.SelectedValue = d.spesialis;

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var r = from d in db.Dokters
                    where d.kode_dokter == kode.Text
                    select d;

            Dokter obj = r.SingleOrDefault();

            if (obj != null)
            {
                obj.nama_dokter = nama.Text;
                obj.alamat = alamat.Text;
                obj.no_telp = no_telp.Text;
                obj.pendidikan = pendidikan.Text;
                obj.spesialis = spesialis.SelectedValue.ToString();

                db.SaveChanges();
                dataGrid.Items.Refresh();
            }
        }
    }
}

