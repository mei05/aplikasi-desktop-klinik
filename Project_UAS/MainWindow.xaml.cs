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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_UAS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        puskesmasEntities db = new puskesmasEntities();
        public static MainWindow menu;
        void terkunci()
        {
            mnLogin.IsEnabled = true;
            mnPasien.IsEnabled = false;
            mnDokter.IsEnabled = false;
            mnObat.IsEnabled = false;
            mTransaksi.IsEnabled = false;
            menu = this;
        }
        public MainWindow()
        {
            InitializeComponent();
            terkunci();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void mnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
