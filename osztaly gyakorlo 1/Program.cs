using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztaly_gyakorlo_1
{
    public abstract class Address
    {
        public abstract void display();

        

        static void Main(string[] args)
        {
            Console.WriteLine("Address");

            string street;
            string city;
            string state;
            string postalCode;
            string country;
            string outputAsLabel;

            Console.WriteLine("Utca:");
            Console.WriteLine("Város:");
            Console.WriteLine("Állapot:");
            Console.WriteLine("postaKód:");
            Console.WriteLine("Ország:");

            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }
    }
}
