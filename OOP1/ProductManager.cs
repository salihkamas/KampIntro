using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi.");
        }

        public int Topla(int num1 , int num2)
        {
            return num1 + num2;
        }
        public void Topla2(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }
    }
}
