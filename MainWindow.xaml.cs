using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Banki
{
  
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a = 0;
        
        string bankname1, prodname1;

      static  BankProduct product1 = new BankProduct();
      static BankProduct product2 = new BankProduct();
       static BankProduct product3 = new BankProduct();
       static BankProduct product4 = new BankProduct();
       static BankProduct product5 = new BankProduct();
       static public BankProduct[] bankProducts = { product1, product2, product3, product4,product5 };

        static public double txtbxvalue1 { get; set; }
        static public double txtbxvalue2 { get; set; }

        static public bool ItIsСontribution = true;
        
      

        private void btnСontribution_Click(object sender, RoutedEventArgs e)
        {
            btnСontribution.Background = new SolidColorBrush(Color.FromRgb(240, 240, 240));
            btnLoan.Background = new SolidColorBrush(Color.FromRgb(220, 220, 220));
            btnShowResult.Content = "Подобрать Вклад";
            
            ItIsСontribution = true;
            viplatyorzaim.Content = "Выплаты ";



        }

        private void btnLoan_Click(object sender, RoutedEventArgs e)
        {
            btnLoan.Background = new SolidColorBrush(Color.FromRgb(240, 240, 240));
            btnСontribution.Background = new SolidColorBrush(Color.FromRgb(220, 220, 220));
            btnShowResult.Content = "Подобрать Займ";
            viplatyorzaim.Content = "Должен ";
            ItIsСontribution= false;
          
        }

        private void cmbbxYears_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnShowResult_Click(object sender, RoutedEventArgs e)
        {
            
            if (ItIsСontribution == true)
            {
                MessageBox.Show(CustomerBenefitCalculator.GetBankAndProductName(bankProducts));
                lblStavka.Content = CustomerBenefitCalculator.GetBankProduct(bankProducts).PercentPerYear;
              
                lblViplaty1.Content = 1 + txtbxvalue1 + txtbxvalue1 * ((Convert.ToDouble(lblStavka.Content)) / 100) * txtbxvalue2;
            }
            else
            {
                MessageBox.Show(CustomerBenefitCalculator.GetBankAndProductName(bankProducts));
                lblStavka.Content = CustomerBenefitCalculator.GetBankProduct(bankProducts).PercentPerYear;
                lblViplaty1.Content = txtbxvalue1 * (Convert.ToDouble(lblStavka.Content)/100)/365*(txtbxvalue2*365) + txtbxvalue1;

            }
            

            

        }

        private void txtbxValue1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                txtbxvalue1 = Convert.ToDouble(txtbxValue1.Text);
            }
            catch (Exception)
            {


            }
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtbxValue2_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                txtbxvalue2 = Convert.ToDouble(txtbxValue2.Text);
            }
            catch (Exception)
            {

                
            }


        }
    }
}
