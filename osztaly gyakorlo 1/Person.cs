using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztaly_gyakorlo_1
{
    public class Person : Address
    {
        public override void display()
        {
            Console.WriteLine("Person");
            string nev;
            string phoneNumber;
            string emailAddress;
            int purchaseParkingPass;

            Console.WriteLine("Név:");
            Console.WriteLine("Telefonszám:");
            Console.WriteLine("E-mail cím:");
            Console.WriteLine("Parkolási díj:");
        }
    }
}
