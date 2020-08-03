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
            //Intialize
            fixedSKUs = PopulateSKUs();
            IntializeScenario();

            var cart = initialCart;
            Console.WriteLine("Promotion rules applied: ");
            
            //Apply all rules
            foreach(var rule in rules)
            {
                //Apply each rule repeatedly
                while(rule.IsApplicable(cart))
                {
                    cart = rule.Apply(cart);
                    Console.WriteLine(rule.getPrettyMessage());
                }
            }

            // Print out the items that didn't belong to any rule
            Console.WriteLine();
            Console.WriteLine("Individual Items");
            foreach(var item in cart)
            {
                Console.WriteLine("Individual "+item+" for "+fixedSKUs.Where(x => x.letter == item).First().price);
            }

        }

        // present the available SKUs here
        public static List<SKU> PopulateSKUs()
        {
            List<SKU> list = new List<SKU>();
            list.Add(new SKU {letter='A',price=50});
            list.Add(new SKU {letter='B',price=30});
            list.Add(new SKU {letter='C',price=20});
            list.Add(new SKU {letter='D',price=15});

            return list;
        }


        //write values here for different scenarios
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
