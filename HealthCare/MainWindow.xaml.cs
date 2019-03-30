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

namespace HealthCare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Islam islam = new Islam();
            islam.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AbuZahra abuZahra = new AbuZahra();
            abuZahra.Show();
        }

        private void AhmedClick(object sender, RoutedEventArgs e)
        {
            AhmedKhalil ahmedKhalil = new AhmedKhalil();
            ahmedKhalil.Show();
        }

        private void ButtRana_Click(object sender, RoutedEventArgs e)
        {
            Rana rana = new Rana();
            rana.Show();
        }
    }
}
