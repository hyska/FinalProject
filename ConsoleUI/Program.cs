﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle-yeni özellik eklediğinde eski kodlara dokunmazsın
    class Program
    {
        //IoC
        //Data Transformation Object
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetAll();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.UnitPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            //foreach (var product in productManager.GetProductDetails().Data)
            //{
            //    Console.WriteLine(product.ProductName + " / " + product.CategoryName);

            //}
        }
    }
}
