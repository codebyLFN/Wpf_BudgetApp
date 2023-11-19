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
    /// Interaction logic for Buying.xaml
    /// </summary>
    public partial class Buying : Page
    {
        public static double gross_inco;
        public static double LoanAmountHomeLoan;
        public double Monthly_Payment;
        public static double available_Monthly;
        public static double sum_homeloan;

        internal class Buyings : Budget
        {

            Renting rent = new Renting();
            Buying buy = new Buying();


            public void CalcMonthly()
            {
                Console.WriteLine("\n");
                available_Monthly = (gross_income - monthly_tax) - sum - rent.Monthly_Rental - LoanAmount;
                //Console.WriteLine("The avaiable monthly money is R" + available_Monthly);

            }

            

        }

        public Buying()
        {
            InitializeComponent();
        }

        private void buybtn1_Click(object sender, RoutedEventArgs e)
        {
            Choosevehicle vehicle = new Choosevehicle();
            this.NavigationService.Navigate(vehicle);
        }

        private void buybtn2_Click(object sender, RoutedEventArgs e)
        {
            double propertyPrice;
            double totalDeposit;
            double interestRate;
            double monthrepay;

            double A;
            double Year;
            double Rate;

            propertyPrice = Convert.ToDouble(buytb1.Text);
            totalDeposit = Convert.ToDouble(buytb2.Text);
            interestRate = Convert.ToDouble(buytb3.Text);
            monthrepay = Convert.ToDouble(buytb5.Text);

            Rate = interestRate / 100;
            Year = monthrepay / 12;

            //Calculating the deposit and the price of the house
            //Console.WriteLine("A=P(1+in)");
            A = ((propertyPrice - totalDeposit)) + (1 + Rate * Year);

            Monthly_Payment = (A / Year);


            LoanAmountHomeLoan = totalDeposit * (1 + Rate * Year);


            buytb4.Text = "The users monthly payment will be : R" + Math.Round(Monthly_Payment, 2)
                + "\n" + "The monthly home loan amount is: R" + Math.Round(LoanAmountHomeLoan, 2) + "\n" +
                "Your available money is" + Math.Round(available_Monthly, 2);
        }
    }
}
