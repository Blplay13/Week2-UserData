using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm kusib kasutaja vanust;
            //programm arvutab kasutaja sunniaasta
            //"oled sunnitud aastal {yearOfBirth}

            Console.WriteLine("Palun sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - userAge;

            Console.WriteLine($"Oled sundinud aastal {yearOfBirth}");
        }
    }
}
