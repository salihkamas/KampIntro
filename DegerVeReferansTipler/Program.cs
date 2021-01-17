using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,boolean,double Değer Tip
            // Array , class , interface Referans Tip

            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            //num1 ?? 30

            int[] numbers1 = new int[] { 10, 20, 30, 40 };
            int[] numbers2 = new int[] { 100, 200, 300, 400 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            // numbers1[0] ?? 999
        }
    }
}
