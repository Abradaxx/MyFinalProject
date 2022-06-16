using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //O---> Open Closed Principle 
    //InMemoryden EfProductDal a çektim 

    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();


        }

       // private static void CategoryTest()
       // {
       //     CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
       //     foreach (var category in categoryManager.GetAll())
       //     {
       //         Console.WriteLine(category.CategoryName);
       //     }
       // }

       //// private static void ProductTest()
       // {
       //     ProductManager productManager = new ProductManager(new EfProductDal());
       //     var result = productManager.GetProductDetails();
       //     if (result.Succes==true)
       //     {
       //         foreach (var item in result.Data)
       //         {
       //             Console.WriteLine(item.ProductName + "/" + item.CategoryName);
       //         }

       //     }
       //     else
       //     {
       //         Console.WriteLine(result.Message);
       //     }
            
       // }
    }
}
