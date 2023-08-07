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
    /// Interaction logic for Transaksi.xaml
    /// </summary>
    public partial class Transaksi : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        string pas, dok, lay, tot;
        public static Transaksi menu;
        void terkunci()
        {
            mnLogin.IsEnabled = false;
            mnTransaksi.IsEnabled = false;
            menu = this;
        }
        public Transaksi()
        {
            InitializeComponent();
            bindCombo();
            cbPasien();
            cbDokter();
            terkunci();
            int i = 1;
            var tr = from d in db.Transaksis
                     select new
                     {
                         kode = d.kode_transaksi
                     };

            foreach (var item in tr)
            {
                    do
                    {
                        if (kode.Text.Equals(item))
                        {
                            kode.Text += item;
                        }
                        else if (i < 10)
                        {
                            kode.Text = "TR00" + i;
                        }
                        else if (i < 100)
                        {
                            kode.Text = "TR0" + i;
                        }
                        else
                        {
                            kode.Text = "TR" + i;
                        }
                        i++;
                    } while (i >= 1000);
                }            
            kode.IsEnabled = false;
        }

        public List<Pasien> pasiens { get; set; }
        public void cbPasien()
        {
            var a = db.Pasiens.ToList();
            pasiens = a;
            pasien.DataContext = pasiens;
        }

        public List<Dokter> dokters { get; set; }
        public void cbDokter()
        {
            var b = db.Dokters.ToList();
            dokters = b;
            dokter.DataContext = dokters;
        }

        public List<Obat> obats { get; set; }
        private void bindCombo()
        {
            var item = db.Obats.ToList();
            obats = item;
            layanan.DataContext = obats;
        }

        private void mnHTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Riwayat r = new Riwayat();
            r.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Kode dokter : " + dok + "\nKode pasien : " + pas + "\nKode Layanan : " + lay);
            try
            {
                Transaksi tr = new Transaksi()
                {
                    kode_transaksi = kode.Text,
                    kode_dokter = dok,
                    kode_pasien = pas,
                    kode_obat = lay,
                    tanggal = DateTime.Today,
                    total = int.Parse(tot),

                };

                db.Transaksis.Add(tr);
                db.SaveChanges();
                MessageBox.Show("Data Berhasil Ditambahkan!");
                this.Hide();
                Riwayat dl = new Riwayat();
                dl.Show();

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void mnPasienLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Pasien ep = new Data_Pasien();
            ep.Show();
            this.Close();
        }

        private void mnPasienBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Pasien ep = new Tambah_Pasien();
            ep.Show();
            this.Close();
        }

        private void mnDokterLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Dokter ep = new Data_Dokter();
            ep.Show();
            this.Close();
        }

        private void mnDokterBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Dokter ep = new Tambah_Dokter();
            ep.Show();
            this.Close();
        }

        private void mnObatLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Layanan ep = new Data_Layanan();
            ep.Show();
            this.Close();
        }

        private void mnObatBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Layanan ep = new Tambah_Layanan();
            ep.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Home m = new Home();
            m.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void dokter_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var b = dokter.SelectedItem as Dokter;
            dok = dokter.SelectedValue.ToString();
        }

        private void pasien_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var a = pasien.SelectedItem as Pasien;
            pas = pasien.SelectedValue.ToString();
        }

        private void layanan_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var item = layanan.SelectedItem as Obat;
            lay = layanan.SelectedValue.ToString();
            int total = (int)((Obat)layanan.SelectedItem).harga;
            tot = total.ToString();
            hitung.Text = tot;
        }
    }
}
