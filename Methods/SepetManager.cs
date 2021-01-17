using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // Naming Convention
        // Syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + product.Adi);
        }

        public void Add2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urunAdi);
        }
    }
}
