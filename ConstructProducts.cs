using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Banki
{
    // этот класс генерирует значения всех полей у продукта банка
    static class CreateProduct
    {
       static Random random = new Random();
        private static string prname = null;
        public static string bankname { get; private set; }
        public static double percent { get; private set; }
        public static double mintern { get; private set; }
        public static double maxtern { get; private set; }
        public static double minprice { get; private set; }
        public static double maxprice { get; private set; }


        public static string CreateProductName()
        {
            if (MainWindow.ItIsСontribution == true)
            {
                prname = depositNames.OrderBy(x => random.Next()).First(); percent = random.Next(1, 20); 

                return prname;


            }
            else
            {
                prname = loanNames.OrderBy(x => random.Next()).First(); percent = random.Next(1, 20);

                return prname;
            }
        }
        
        public static string CreateBankName()
        {
            return bankname = bankNames.OrderBy(x => random.Next()).First();
        }

        public static double CreateProductPercent()
        {
            return percent = random.Next(0, 20);
        }
        public static double CreateProductMinTerm()
        {
            return mintern = random.Next(1,2);
        }
        public static double CreateProductMaxTerm()
        {
            return percent = random.Next(1, 10);
        }
        public static double CreateProductMinPrice()
        {
            return minprice = random.Next(10_000,100_000);
        }
        public static double CreateProductMaxPrice()
        {
            return percent = random.Next(100_000, 100_000_00);
        }



        private static string[] depositNames = 
         {
            
             "SecureSave",
             "TrustDeposit",
             "WealthGuard",
             "FlexiSaver",
             "CashLock",
             "PrimeGrow",
             "SmartSecure",
             "FutureVault",
              "ProActiveDeposit",
             "InvestShield"
        };

        private static string[] loanNames =
        {
        
              "SwiftFund",
               "EasyLend",
              "PowerLoan",
              "QuickCash",
               "SpeedCredit",
              "FlexiFinance",
              "SecureMortgage",
              "SmartLoan",
             "DreamAdvance",
             "ProsperityPlus"
        };
        private static string[] bankNames = {"Сбербанк", "Тинькофф","Почтабанк","БэбраАмэриканБанк2004" };
        


    }
 }

