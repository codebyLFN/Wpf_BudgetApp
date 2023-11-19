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
    /// Interaction logic for Renting.xaml
    /// </summary>
    public partial class Renting : Page
    {
        public double Monthly_Rental;
        public Renting()
        {
            InitializeComponent();
        }

        private void rentbtn2_Click(object sender, RoutedEventArgs e)
        {
            Monthly_Rental = Convert.ToDouble(renttb.Text);
            renttb2 .Text = "Your monthly rental amount is R" + Monthly_Rental;
        }

        private void rentbtn1_Click(object sender, RoutedEventArgs e)
        {
            Choosevehicle vehicle = new Choosevehicle();
            this.NavigationService.Navigate(vehicle);
        }
    }
}
