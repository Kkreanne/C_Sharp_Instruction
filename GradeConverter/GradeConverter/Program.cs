using System;

namespace GradeConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Letter Grade Converter!");

            string choice = "y";
            while (choice.Equals("y")) {

                Console.WriteLine("Enter Numerical Grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 90 && grade <= 100) {
                    Console.WriteLine("Letter Grade is: A ");
                } else if (grade >= 80 && grade <= 89) {
                    Console.WriteLine("Letter Grade is: B ");
                } else if (grade >= 70 && grade <= 79) {
                    Console.WriteLine("Letter Grade is: C ");
                } else if (grade >= 60 && grade <= 69) {
                    Console.WriteLine("Letter Grade is: D ");
                } else if (grade >= 50 && grade <= 59) {
                    Console.WriteLine("Letter Grade is: F ");
                } 
                
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
