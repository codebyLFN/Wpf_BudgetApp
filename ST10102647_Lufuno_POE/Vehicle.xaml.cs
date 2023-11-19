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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Page
    {
        public delegate void NotificationAlert(String loan);
        public static double LoanAmountVechile;
        public static double monthlyCost;
        public static double vehicle_gross_income;
        public static double vehicle_sum;
        public static double vehicle_LoanAmount;


        public Vehicle()
        {
            InitializeComponent();
        }

        private void vehbtn2_Click(object sender, RoutedEventArgs e)
        {
            String Model;
            String Make;
            double Purchase_Price;
            double deposit;
            double interest_rate;
            double est_insurance_premium;
            double emivechilce = 0;

            Model = vehtb2.Text;
            Make = vehtb1.Text;
            Purchase_Price = Convert.ToDouble(vehtb3.Text);
            deposit = Convert.ToDouble(vehtb4.Text);
            interest_rate = Convert.ToDouble(vehtb5.Text);
            est_insurance_premium = Convert.ToDouble(vehtb6.Text);

            //Calculation for monthly payment
            emivechilce = emi_calculator(Purchase_Price - deposit + est_insurance_premium, interest_rate, 5);
            vehlistbox.Text = "Vehicle  monthly payment>> " + "R " + Math.Round(emivechilce, 2);

            static double emi_calculator(double p, double r, double t)
            {
                double emi;

                r = r / (12 * 100); // one month interest
                t = t * 12; // one month period
                emi = (p * r * (double)Math.Pow(1 + r, t)) / (double)(Math.Pow(1 + r, t) - 1);
                return emi;
            }
        }

        private void vehbtn1_Click(object sender, RoutedEventArgs e)
        {
            Saving save = new Saving();
            this.NavigationService.Navigate(save);
        }
    }
}
