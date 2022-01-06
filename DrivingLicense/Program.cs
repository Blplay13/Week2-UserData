using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutaja sunniaasta;
            //programm arvutab kasutaja vanuse;
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis;
            //"oled liiga noor, et juhilube saada"
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis;
            //"oled piisavalt vana, et juhilube saada"
            //kui kasutaja on 18, siis programm kuvab konsoolis;
            //"Palju onne! Nuud sa saada ka juhiluba taotleda";

            Console.WriteLine("Palun sisesta oma sunniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            Console.WriteLine("Sa oled " + userAge + "aastat vana.");

            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada!");

            }
            else
            {
                Console.WriteLine("Palju onne ! Nuud saad ka omale juhiloa taotleda.");
            }


            Console.WriteLine("Kena paeva jatku");
        }
    }
}
