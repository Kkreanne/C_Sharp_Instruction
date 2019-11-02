using System;
using System.Collections;
using System.Collections.Generic;

namespace ProductManager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome !");

            int i1 = GetInt("Enter a whole number: ");
            Console.WriteLine("i1 = " + i1);

            string name = "";
            name = GetString("Enter you're name: ");

            printThreeNumbers(5, 6, 7);
            printThreeNumbers();
            printThreeNumbers(8,9);
            printThreeNumbers(3, c:10); //excepts default for b, clarify if you want to define/change c


            Product p1 = new Product("java", "Murach", 59.50);
            Console.WriteLine(p1);


            //need to add new class book
            //Book b1 = new Book {Code = "c#", Description = "Murachs", Price = 45.99, Author = "Joel Murach"};

            Product p2 = new Product("andr", "Murach Android", 29.50);
            Product[] products = { p1, p2 };

            foreach (Product pdt in products) {
                Console.WriteLine(pdt);
            }


            ArrayList productList1 = new ArrayList();
            productList1.Add(p1);
            productList1.Add(p2);

            Product p = (Product)productList1[0];
            List<Product> productList2 = new List<Product>();
            productList2.Add(p1);
            productList2.Add(p2);

            p = productList2[0];


            //c# dictionary is similar to java hash map
            Console.WriteLine("Use a Dictionary..");
            Dictionary<string, Product> productDictionary = new Dictionary<string, Product>();
            productDictionary.Add(p1.Code, p1);
            productDictionary.Add(p2.Code, p2);

            p = productDictionary["andr"];
            Console.WriteLine(p);


            Console.WriteLine("Bye");
        }

        private static void printThreeNumbers(int a=1, int b=2, int c=3) {
            Console.WriteLine(a + ", " + b + ", " + c);
        }



        private static string GetString(string prompt) {
            string name;
            Console.WriteLine();
            name = Console.ReadLine();
            return name;
        }
/*
        // with exception handling
        private static int GetInt(string prompt) {
            int i = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                string s = Console.ReadLine();
                try {
                    i = Convert.ToInt32(s);
                    success = true;
                }
                catch (Exception) {
                    Console.WriteLine("Error - not a whole number: "+s);
                }
            }

            return i;
        }
*/        // with data validation
        private static int GetInt(string prompt) {
            int i = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                string s = Console.ReadLine();
                    if (int.TryParse(s, out i)) {
                    success = true;
                    }
                    else {
                    Console.WriteLine("Error, not a whole #: " + s);
                    }
            }

            return i;
        }
    }
}