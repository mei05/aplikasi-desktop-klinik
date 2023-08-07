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
    /// Interaction logic for Riwayat.xaml
    /// </summary>
    public partial class Riwayat : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static Riwayat menu;
        public static DataGrid dataGrid;
        void terkunci()
        {
            mnLogin.IsEnabled = false;
            mnHTransaksi.IsEnabled = false;
            menu = this;
        }
        public Riwayat()
        {
            InitializeComponent();
            terkunci();
            var result = from a in db.Transaksis
                         select new
                         {
                             a.kode_transaksi,
                             a.kode_dokter,
                             a.Dokter.nama_dokter,
                             a.kode_pasien,
                             a.Pasien.nama_pasien,
                             a.kode_obat,
                             a.Obat.nama_obat,
                             a.tanggal,
                             a.total
                         };

            var resultOuterDoctor = from d in db.Dokters
                                    from c in db.Obats
                                    from b in db.Pasiens
                                    from a in d.Transaksis.DefaultIfEmpty()
                                    select new
                                    {
                                        d.nama_dokter,
                                        a.kode_transaksi,
                                        a.tanggal,
                                        b.nama_pasien,
                                        c.harga,
                                        c.nama_obat
                                    };

            this.tabel.ItemsSource = result.ToList();
        }

        private void mnTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Transaksi t = new Transaksi();
            t.Show();
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

        private void mnObatLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Layanan r = new Data_Layanan();
            r.Show();
            this.Close();
        }
        //function cari
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = from a in db.Transaksis
                         where a.kode_transaksi == cari.Text
                         select new
                         {
                             a.kode_transaksi,
                             a.kode_dokter,
                             a.Dokter.nama_dokter,
                             a.kode_pasien,
                             a.Pasien.nama_pasien,
                             a.kode_obat,
                             a.Obat.nama_obat,
                             a.tanggal,
                             a.total
                         };

            var resultOuterDoctor = from d in db.Dokters
                                        from c in db.Obats
                                        from b in db.Pasiens
                                        from a in d.Transaksis.DefaultIfEmpty()
                                        where a.kode_transaksi == cari.Text
                                        select new
                                        {
                                            d.nama_dokter,
                                            a.kode_transaksi,
                                            a.tanggal,
                                            b.nama_pasien,
                                            c.harga,
                                            c.nama_obat
                                        };

                this.tabel.ItemsSource = result.ToList();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
