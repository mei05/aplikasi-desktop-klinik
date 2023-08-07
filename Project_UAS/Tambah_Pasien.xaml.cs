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
using System.Data.Entity.Validation;

namespace Project_UAS
{
    /// <summary>
    /// Interaction logic for Tambah_Pasien.xaml
    /// </summary>
    public partial class Tambah_Pasien : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static Tambah_Pasien menu;
        public static DataGrid dataGrid;
        string ag, st, jk;
        void terkunci()
        {
            mnLogin.IsEnabled = false;
            mnPasienBaru.IsEnabled = false;
            menu = this;
        }
        public Tambah_Pasien()
        {
            InitializeComponent();
            terkunci();

            int i = 1;
            var pasien = from d in db.Pasiens
                         select new
                         {
                             kode = d.kode_pasien
                         };

            foreach (var item in pasien)
            {
                    do
                    {
                        if (kode.Text.Equals(item))
                        {
                            kode.Text += item;
                        }
                        else if (i < 10)
                        {
                            kode.Text = "PS00" + i;
                        }
                        else if (i < 100)
                        {
                            kode.Text = "PS0" + i;
                        }
                        else
                        {
                            kode.Text = "PS" + i;
                        }
                        i++;
                    } while (i >= 1000);
                kode.IsEnabled = false;
            }
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lk.IsChecked == true)
            {
                jk = "Laki-laki";
            }
            else
            {
                jk = "Perempuan";
            }
            if (sudah.IsChecked == true)
            {
                st = "Sudah Menikah";
            }
            else
            {
                st = "Belum Menikah";
            }
            ag = agama.SelectedValue.ToString();
            Pasien pasien = new Pasien()
            {
                kode_pasien = kode.Text,
                nama_pasien = nama.Text,
                tempat_lahir = tempat_lahir.Text,
                tanggal_lahir = tanggal_lahir.SelectedDate,
                alamat = alamat.Text,
                jenis_kelamin = jk,
                agama = ag,
                status = st
            };

            db.Pasiens.Add(pasien);
            db.SaveChanges();
            MessageBox.Show("Data Berhasil Ditambahkan!");
            this.Hide();
            Data_Pasien dl = new Data_Pasien();
            dl.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow aPage = new MainWindow();
            aPage.Show();
            this.Close();
        }


        private void mnPasienLama_Click(object sender, RoutedEventArgs e)
        {
            Data_Pasien ep = new Data_Pasien();
            ep.Show();
            this.Close();
        }

        private void mnObatBaru_Click(object sender, RoutedEventArgs e)
        {
            Tambah_Layanan np = new Tambah_Layanan();
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Home h = new Home();
            h.Show();
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
