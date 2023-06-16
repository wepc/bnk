using System;
using System.Linq;
using System.Security.Cryptography;
using System.Web;


namespace Banki
{
    // экземпляры этого класса являются продуктами банков
      public class BankProduct
      {
        public string NameOfProduct { get;private set; }
        public string NameOfBank{ get; private set; }
        public double PercentPerYear { get; private set; }
        public double MinimumTerm { get; private set; } // ne dlya logici v classah
        public double MaxTerm { get; private set; }
        public double MinimumPrice { get; private set; } // ne dlya logici v classah
        public double MaxPrice { get; private set; }
        public BankProduct()
        {
            NameOfBank = CreateProduct.CreateBankName();
            NameOfProduct = CreateProduct.CreateProductName();
            PercentPerYear = CreateProduct.CreateProductPercent();
            MinimumTerm = CreateProduct.CreateProductMinTerm();
            MaxTerm = CreateProduct.CreateProductMaxTerm();
            MinimumPrice = CreateProduct.CreateProductMinPrice();
            MaxPrice = CreateProduct.CreateProductMaxPrice();

        }
        

    } 
































    //public abstract class BankProduct
    //{
    //    public abstract string NameOfProduct { get; set; }
    //    public abstract string[] ArrofProps { get; set; }
    //    public abstract double PercentPerYear { get; set; }
    //    public abstract double MinimumTerm { get; set; }
    //    public abstract double MaxTerm { get; set; }
    //    public abstract double MinimumPrice { get; set; }
    //    public abstract double MaxPrice { get; set; }








    //}
    //public class TinkoffProd : BankProduct
    //{

    //    public string NameOfBank { get; private set; }
    //    public override string NameOfProduct { get; set; }
    //    public override double PercentPerYear { get; set; }
    //    public override double MinimumTerm { get; set; }
    //    public override double MaxTerm { get; set; }
    //    public override double MaxPrice { get; set; }
    //    public override double MinimumPrice { get; set; }
    //    public override string[] ArrofProps { get; set; }

    //    public TinkoffProd()
    //    {
    //        NameOfProduct = CreateProduct.CreateProductName();
    //        PercentPerYear = CreateProduct.CreateProductPercent();
    //        MinimumTerm = CreateProduct.CreateProductMinTerm();
    //        MaxTerm = CreateProduct.CreateProductMaxTerm();
    //        MinimumPrice = CreateProduct.CreateProductMinPrice();
    //        MaxPrice = CreateProduct.CreateProductMaxPrice();
    //        NameOfBank = "Тинькофф";
    //    }




    //}
    //public class GazprombankProd : BankProduct
    //{
    //    public string NameOfBank { get; private set; }
    //    public override string NameOfProduct { get; set; }
    //    public override double PercentPerYear { get; set; }
    //    public override double MinimumTerm { get; set; }
    //    public override double MaxTerm { get; set; }
    //    public override double MaxPrice { get; set; }
    //    public override double MinimumPrice { get; set; }
    //    public override string[] ArrofProps { get; set; }

    //    public GazprombankProd()
    //    {

    //        NameOfProduct = CreateProduct.CreateProductName();
    //    NameOfProduct = CreateProduct.CreateProductName();
    //    PercentPerYear = CreateProduct.CreateProductPercent();
    //    MinimumTerm = CreateProduct.CreateProductMinTerm();
    //    MaxTerm = CreateProduct.CreateProductMaxTerm();
    //    MinimumPrice = CreateProduct.CreateProductMinPrice();
    //    MaxPrice = CreateProduct.CreateProductMaxPrice();
    //    NameOfBank = "Газпромбанк";
    //    }




    //}
    //public class OtkrytieProd : BankProduct
    //{
    //    public string NameOfBank { get; private set; }
    //    public override string NameOfProduct { get; set; }
    //    public override double PercentPerYear { get; set; }
    //    public override double MinimumTerm { get; set; }
    //    public override double MaxTerm { get; set; }
    //    public override double MaxPrice { get; set; }
    //    public override double MinimumPrice { get; set; }
    //    public override string[] ArrofProps { get; set; }

    //    public OtkrytieProd()
    //    {
    //        NameOfProduct = CreateProduct.CreateProductName();
    //    NameOfProduct = CreateProduct.CreateProductName();
    //    PercentPerYear = CreateProduct.CreateProductPercent();
    //    MinimumTerm = CreateProduct.CreateProductMinTerm();
    //    MaxTerm = CreateProduct.CreateProductMaxTerm();
    //    MinimumPrice = CreateProduct.CreateProductMinPrice();
    //    MaxPrice = CreateProduct.CreateProductMaxPrice();
    //    NameOfBank = "Открытие";
    //    }




    //}
    //public class PochtaBankProd : BankProduct
    //{
    //    public string NameOfBank { get; private set; }
    //    public override string NameOfProduct { get; set; }
    //    public override double PercentPerYear { get; set; }
    //    public override double MinimumTerm { get; set; }
    //    public override double MaxTerm { get; set; }
    //    public override double MaxPrice { get; set; }
    //    public override double MinimumPrice { get; set; }
    //    public override string[] ArrofProps { get; set; }

    //    public PochtaBankProd()
    //    {
    //        NameOfProduct = CreateProduct.CreateProductName();
    //    NameOfProduct = CreateProduct.CreateProductName();
    //    PercentPerYear = CreateProduct.CreateProductPercent();
    //    MinimumTerm = CreateProduct.CreateProductMinTerm();
    //    MaxTerm = CreateProduct.CreateProductMaxTerm();
    //    MinimumPrice = CreateProduct.CreateProductMinPrice();
    //    MaxPrice = CreateProduct.CreateProductMaxPrice();
    //    NameOfBank = "Почта Банк";
    //    }
    //}







}
