using Newtonsoft.Json;
using System;

namespace ConsoleApp
{
    class Program
    {
        //這是一個透過 JSON.NET 將 ValutTuple 序列化的主控台應用程式
        //
        //參考的連結
        //https://dotblogs.com.tw/aspnetshare/2017/02/24/20170223-valuetuple
        //

        static void Main(string[] args)
        {
            var _info = GetProductInfo(1);
            var _json = JsonConvert.SerializeObject(_info, Formatting.Indented);

            Console.WriteLine(_json);

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }

        static (Product, ProductPrice) GetProductInfo(int no)
        {
            Product _product;
            ProductPrice _price;

            _product = new Product();
            _price = new ProductPrice();

            _product.No = 1;
            _product.Schema = "MICROSOFTSURPRO6";
            _product.Name = "Surface Pro 6";

            _price.PurchasePrice = 15000;
            _price.AdvicePrice = 47000;
            _price.SellPrice = 45000;

            return (_product, _price);
        }
    }


}
