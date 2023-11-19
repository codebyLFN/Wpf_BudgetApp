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
    /// Interaction logic for Choosevehicle.xaml
    /// </summary>
    public partial class Choosevehicle : Page
    {
        public Choosevehicle()
        {
            InitializeComponent();
        }

        private void rb3_Checked(object sender, RoutedEventArgs e)
        {
            Vehicle car = new Vehicle();
            this.NavigationService.Navigate(car);
        }

        private void rb4_Checked(object sender, RoutedEventArgs e)
        {
            Saving save = new Saving();
            this.NavigationService.Navigate(save);
        }
    }
}
