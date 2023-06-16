using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Banki
{
    //в этом классе происходит сравнение и выдача результата
    static class CustomerBenefitCalculator
    {
       static  string NameProduct;
       static double t = double.MaxValue;
       static double c = double.MaxValue;
        static public string GetBankAndProductName(BankProduct[] products)
        {
            products = MainWindow.bankProducts;
            double closestprice = 0;
           
            double closestterm = 0;
          
            
            for (int i = 0; i < products.Length; i++)
            {
                double a = products[i].MaxPrice - MainWindow.txtbxvalue1;
                double b = products[i].MaxTerm - MainWindow.txtbxvalue2;
                if (a < t || b < c)
                {
                    t = a; 
                    c = b;
                   
                    closestprice = products[i].MaxPrice;
                    closestterm = products[i].MaxTerm;
                    NameProduct = products[i].NameOfProduct ;
                    return NameProduct + " " + products[i].NameOfBank /* + " " + Convert.ToString(closestprice) + " "+Convert.ToString(closestterm)*/ ;
                    
                }

            }





            return products[1].NameOfBank;
        }
         
        static public BankProduct GetBankProduct(BankProduct[] products)  
        {
           
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].NameOfProduct == NameProduct)
                {
                    return products[i];
                }

            }
            return null;
        }
       
       
      

    }

}
