using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagrammAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 voi 13 aastat vana;
            //kui kasutaja on 13 aastat vana voi vanem, siis ta voib instagrammi kasutada;
            //kui kasutaja on noorem kui 13, siis ta on liiga noor

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrammi kontot luua");

            }

            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrammi kontot luua.");
            }

            else
            {
                Console.WriteLine("Oledki 13! Nuud saad endale Instagrammi kontot luua.");

            }
            Console.WriteLine("Kena paeva!");
        }
    }
}
