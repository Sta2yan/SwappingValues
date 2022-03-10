using System;
using System.Collections.Generic;

namespace SwappingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Журавлев";
            string surname = "Станислав";
            string tempName;

            Console.WriteLine($"Имя: - {name} | Фамилия - {surname}");

            tempName = name;
            name = surname;
            surname = tempName;

            Console.WriteLine($"Имя: - {name} | Фамилия - {surname}");
        }
    }
}