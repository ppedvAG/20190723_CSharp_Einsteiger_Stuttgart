﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {

            Fahrzeug einFahrzeug = new Auto();
            Console.WriteLine($"{einFahrzeug.BeschreibeMich()}");
            Console.ReadLine();
        }
    }
}
