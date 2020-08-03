using System;
using System.Collections.Generic;
using PromotionMain.Models;

namespace PromotionMain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<SKU> PopulateSKUs()
        {
            List<SKU> list = new List<SKU>();
            list.Add(new SKU {letter='A',price=50});
            list.Add(new SKU {letter='B',price=30});
            list.Add(new SKU {letter='C',price=20});
            list.Add(new SKU {letter='D',price=15});

            return list;
        }
    }
}
