using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppleStoreLibrary01;
namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1[] products = new Class1[]
            {
                new Class1()
                {
                id=1,
                Name="iphone",
                Price=28900,
                categories=new string[] {"iphone"}
                },
                new Class1()
                {
                id = 2,
                Name = "iphone+",
                Price = 31900,
                categories = new string[] { "iphone" }
                 }

        };
            Console.WriteLine(products[0].Name);
            Console.WriteLine("共有{0}個產品", products.Length);
        }
    }
}