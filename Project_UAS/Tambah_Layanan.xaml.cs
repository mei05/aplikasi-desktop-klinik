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
    /// Interaction logic for Tambah_Layanan.xaml
    /// </summary>
    public partial class Tambah_Layanan : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static Tambah_Layanan menu;
        void terkunci()
        {
            mnLogin.IsEnabled = false;
            mnObatBaru.IsEnabled = false;
            menu = this;
        }
        public Tambah_Layanan()
        {
            InitializeComponent();
            terkunci();

            int i = 1;
            var layanan = from d in db.Obats
                          select new
                          {
                              kode = d.kode_obat
                          };

            foreach (var item in layanan)
            {
                do
                {
                    if (kode.Text.Equals(item))
                    {
                        kode.Text += item;
                    }
                    else if (i < 10)
                    {
                        kode.Text = "LY00" + i;
                    }
                    else if (i < 100)
                    {
                        kode.Text = "LY0" + i;
                    }
                    else
                    {
                        kode.Text = "LY" + i;
                    }
                    i++;
                } while (i >= 1000);
            }
            kode.IsEnabled = false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow aPage = new MainWindow();
            aPage.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Obat newObat = new Obat()
                {
                    kode_obat = kode.Text,
                    nama_obat = nama.Text,
                    harga = int.Parse(harga.Text),

                };

                db.Obats.Add(newObat);
                db.SaveChanges();
                MessageBox.Show("Data Berhasil Ditambahkan!");
                this.Hide();
                Data_Layanan dl = new Data_Layanan();
                dl.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
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

        private void mnObatLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Layanan dl = new Data_Layanan();
            dl.Show();
            this.Close();
        }

        private void mnTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Transaksi tr = new Transaksi();
            tr.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Home main = new Home();
            main.Show();
            this.Close();
        }

        private void mnHTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Riwayat r = new Riwayat();
            r.Show();
            this.Close();
        }
    }
}
