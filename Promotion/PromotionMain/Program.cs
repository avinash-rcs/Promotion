using System;
using System.Collections.Generic;
using PromotionMain.Models;
using PromotionMain.Rules;
using System.Linq;

namespace PromotionMain
{
    public class Program
    {
        static List<SKU> fixedSKUs;
        static List<IRule> rules;
        static List<char> initialCart;

        static void Main(string[] args)
        {
            fixedSKUs = PopulateSKUs();
            IntializeScenario();

            var cart = initialCart;
            Console.WriteLine("Promotion rules applied: ");
            foreach(var rule in rules)
            {
                while(rule.IsApplicable(cart))
                {
                    cart = rule.Apply(cart);
                    Console.WriteLine(rule.getPrettyMessage());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Individual Items");
            foreach(var item in cart)
            {
                Console.WriteLine("Individual "+item+" for "+fixedSKUs.Where(x => x.letter == item).First().price);
            }

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

        public static void IntializeScenario()
        {
            rules = new List<IRule>();
            rules.Add(new Rule1('A',3,130));
            rules.Add(new Rule2('B','C',30));

            initialCart = new List<char>();
            initialCart.Add('A');
            initialCart.Add('A');
            initialCart.Add('A');
            initialCart.Add('A');
            initialCart.Add('B');
            initialCart.Add('C');
        }
    }
}
