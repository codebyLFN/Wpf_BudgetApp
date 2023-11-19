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
    /// Interaction logic for Saving.xaml
    /// </summary>
    public partial class Saving : Page
    {
        public Saving()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double calculation;
            double total;
            double rate;
            double year;
            year = Convert.ToDouble(textbox_months.Text) / 12;
            rate = Convert.ToDouble(textbox_interest.Text) / 100;

            //calculating the first part of the formula
            calculation = (Convert.ToDouble(textbox_money.Text) + 1 + rate
                * year);

            //calculation of the second part formula
            total = calculation - Convert.ToDouble(textbox_money.Text);

            textbox_total.Text = "Your total future savings will be R" + total + " on this day" + textbox_date.Text;

        }
    }
}
