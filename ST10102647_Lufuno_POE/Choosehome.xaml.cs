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

namespace ST10102647_Lufuno_POE_TASK3
{
    /// <summary>
    /// Interaction logic for Choosehome.xaml
    /// </summary>
    public partial class Choosehome : Page
    {
        public Choosehome()
        {
            InitializeComponent();
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            Renting rent = new Renting();
            this.NavigationService.Navigate(rent);
        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            Buying buy = new Buying();
            this.NavigationService.Navigate(buy);
        }
    }
}
