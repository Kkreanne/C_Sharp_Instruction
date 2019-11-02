using System;

namespace StudentRegistration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Student Registration Form\n");

            Console.WriteLine("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            string BirthYear = Console.ReadLine();

            Console.WriteLine("Welcome " + FirstName + " " + LastName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + FirstName + "*" + BirthYear);

            Console.WriteLine("Goodbye!");

        }
    }
}
