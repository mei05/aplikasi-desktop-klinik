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
    /// Interaction logic for Data_Pasien.xaml
    /// </summary>
    public partial class Data_Pasien : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static Data_Pasien menu;
        public static DataGrid dataGrid;
        Pasien p = new Pasien();
        void terkunci()
        {
            mnLogin.IsEnabled = false;
            mnPasienLama.IsEnabled = false;
            menu = this;
        }
        public Data_Pasien()
        {
            InitializeComponent();
            Load();
            terkunci();
        }

        private void Load()
        {
            
            tabel.ItemsSource = db.Pasiens.ToList();
            dataGrid = tabel;
        }

        private void mnObatLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Layanan a = new Data_Layanan();
            a.Show();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void mnPasienBaru_Click_1(object sender, RoutedEventArgs e)
        {
            Tambah_Pasien np = new Tambah_Pasien();
            np.Show();
            this.Close();
        }
        private void GridDoctors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            Pasien d = (Pasien)this.tabel.SelectedItems[0];
            kode.Text = d.kode_pasien;
            nama.Text = d.nama_pasien;
            alamat.Text = d.alamat;
            tempat_lahir.Text = d.tempat_lahir;
            tanggal_lahir.Text = d.tanggal_lahir.ToString();
            agama.SelectedValue = d.agama;
            jenis_kelamin.SelectedValue = d.jenis_kelamin;
            status.SelectedValue = d.status;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var r = from d in db.Pasiens
                    where d.kode_pasien == kode.Text
                    select d;

            Pasien obj = r.SingleOrDefault();

            if (obj != null)
            {
                obj.nama_pasien = nama.Text;
                obj.alamat = alamat.Text;
                obj.tempat_lahir = tempat_lahir.Text;
                obj.tanggal_lahir = tanggal_lahir.SelectedDate;
                obj.jenis_kelamin = jenis_kelamin.SelectedValue.ToString();
                obj.agama = agama.SelectedValue.ToString();
                obj.status = status.SelectedValue.ToString();

                db.SaveChanges();
                dataGrid.Items.Refresh();
            }
        }
    }
}
