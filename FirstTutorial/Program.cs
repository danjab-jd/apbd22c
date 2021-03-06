using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstTutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // AddStudent() - PascalCase
            // addStudent() - camelCase

            Console.WriteLine("Hello World!");

            var stud = new Student
            {
                FirstName = "Piotr",
                Age = 23
            };

            // Interpolacje stringa
            Console.WriteLine($"Imie studenta to: {stud.FirstName} i ma {stud.Age} lat");

            var tmp = "ABC";
            tmp = "CBA";


            var list = new List<string> {"Ala", "ma", "kota"};


            foreach (var wrt in list)
            {
                Console.WriteLine(wrt);
            }


        }
    }
}
