﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm küsib kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");
            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana");


        }
    }
}
