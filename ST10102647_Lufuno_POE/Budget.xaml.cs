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
    /// Interaction logic for Budget.xaml
    /// </summary>
    public partial class Budget : Page
    {
        //
        public static double sum = 0;
        public static double monthly_tax;
        public static double gross_income;
        public static double LoanAmount;

        public Budget()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Choosehome home = new Choosehome();
            this.NavigationService.Navigate(home);

            //
            gross_income = Convert.ToDouble(textbox1.Text);
            monthly_tax = Convert.ToDouble(textbox2.Text);
            sum += Convert.ToDouble(textbox3.Text) + Convert.ToDouble(textbox4.Text)
                + Convert.ToDouble(textbox5.Text) + Convert.ToDouble(textbox6.Text) +
                Convert.ToDouble(textbox7.Text);

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
