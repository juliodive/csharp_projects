﻿using System;
using System.Globalization;

namespace Exer03_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triangulo x:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do Triangulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area do triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}
