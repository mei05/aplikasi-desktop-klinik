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
    /// Interaction logic for Tambah_Dokter.xaml
    /// </summary>
    public partial class Tambah_Dokter : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static Tambah_Dokter menu;
        public static DataGrid dataGrid;
        void terkunci()
        {
            mnLogin.IsEnabled = false;
            mnDokterBaru.IsEnabled = false;
            menu = this;
        }
        public Tambah_Dokter()
        {
            InitializeComponent();
            terkunci();
            int i = 1;
            var dokter = from d in db.Dokters
                          select new
                          {
                              kode = d.kode_dokter
                          };

            foreach (var item in dokter)
            {
                do
                {
                    if (kode.Text.Equals(item))
                    {
                        kode.Text += item;
                    }
                    else if (i < 10)
                    {
                        kode.Text = "DOK00" + i;
                    }
                    else if (i < 100)
                    {
                        kode.Text = "DOK0" + i;
                    }
                    else
                    {
                        kode.Text = "DOK" + i;
                    }
                    i++;
                } while (i >= 1000);
            }
            kode.IsEnabled = false;
        }

        private void mnTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Transaksi t = new Transaksi();
            t.Show();
            this.Close();
        }

        private void mnHTransaksi_Click(object sender, RoutedEventArgs e)
        {
            Riwayat r = new Riwayat();
            r.Show();
            this.Close();
        }

        private void mnObatBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Layanan r = new Tambah_Layanan();
            r.Show();
            this.Close();
        }

        private void mnObatLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Layanan r = new Data_Layanan();
            r.Show();
            this.Close();
        }

        private void mnDokterLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Dokter r = new Data_Dokter();
            r.Show();
            this.Close();
        }

        private void mnPasienBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Pasien r = new Tambah_Pasien();
            r.Show();
            this.Close();
        }

        private void mnPasienLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Pasien r = new Data_Pasien();
            r.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Home r = new Home();
            r.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow r = new MainWindow();
            r.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string sp = spesialis.SelectedValue.ToString();
            Dokter dokter = new Dokter()
            {
                kode_dokter = kode.Text,
                nama_dokter = nama.Text,
                alamat = alamat.Text,
                pendidikan = pendidikan.Text,
                no_telp = no_telp.Text,
                spesialis = sp
            };

            db.Dokters.Add(dokter);
            db.SaveChanges();
            MessageBox.Show("Data Berhasil Ditambahkan!");
            this.Hide();
            Data_Dokter dl = new Data_Dokter();
            dl.Show();
        }
    }
}
