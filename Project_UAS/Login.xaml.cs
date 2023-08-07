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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static MainWindow menu;
        public Login()
        {
            InitializeComponent();
            tampildata();
            terkunci();
        }

        void terkunci()
        {
            mnLogin.IsEnabled = false;
            mnPasien.IsEnabled = false;
            mnDokter.IsEnabled = false;
            mnObat.IsEnabled = false;
            mTransaksi.IsEnabled = false;
        }
        void tampildata()
        {
            db.Users.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (username.Text != string.Empty || password.ToString() != string.Empty)
                {
                    var user = db.Users.Where(m => m.role.Equals(username.Text)).FirstOrDefault();
                    if (user != null)
                    {
                        Home aPage = new Home();
                        aPage.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data Harus Terisi Dengan Benar!");
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error : " + ex.Message,
                    "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow aPage = new MainWindow();
            aPage.Show();
            this.Close();
        }
    }
}
