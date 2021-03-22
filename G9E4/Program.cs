using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace G9E4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = true;
            int mayor_Index, menor_Index;
            double mayor = 0, menor = 0, prom = 0;
            double[] ventas = new double[9];
            Logo();
            for (int i = 0; i < 9; i++)
            {
                while(error == true)
                {
                    try
                    {
                        Console.WriteLine("Indique el total de ventas diarias realizadas durante el mes de " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i + 1) + "...");
                        ventas[i] = double.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch (FormatException err)
                    {
                        Console.WriteLine(err.Message);
                        Console.WriteLine(err.Message);
                        Console.Write("Vuelvalo a intentar .");
                        for (int o = 0; o < 4; o++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        Console.Clear();
                        error = true;
                    }
                }
                error = true;
            }
            mayor = ventas[0];
            menor = ventas[0];
            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] > mayor)
                {
                    mayor = ventas[i];
                }
                if (ventas[i] < menor)
                {
                    menor = ventas[i];
                }
            }
            mayor_Index = Array.IndexOf(ventas, mayor);
            menor_Index = Array.IndexOf(ventas, menor);
            foreach (int valor in ventas)
            {
                prom += valor;
            }
            prom = prom / ventas.Length;
            Console.Clear();
            Console.WriteLine("VALORES INGRESADOS: ");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine("Mes #" + (i + 1) + ": " + ventas[i]);
            }
            Console.WriteLine("\nMES PERTENECIENTE A LA VENTA MAYOR: " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mayor_Index + 1));
            Console.WriteLine("MES PERTENECIENTE A LA VENTA MENOR: " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(menor_Index + 1));
            Console.WriteLine("PROMEDIO DE VENTAS EN " + ventas.Length + " MESES: " + prom);
            Console.ReadKey();
        }


        static void Logo()
        {
            Console.WriteLine("|||||||||||||         |||||||| ||||||| |||   ||| |||  ||| |||   ||| ||| |||||||| ||||||||");
            Console.WriteLine("     |||              |||      ||   || |||| |||| |||  ||| ||||  ||| ||| |||      |||  |||");
            Console.WriteLine("     |||              |||      ||   || ||| | ||| |||  ||| ||||  ||| ||| |||      |||  |||");
            Console.WriteLine("     |||              |||      ||   || |||   ||| |||  ||| ||| | ||| ||| |||      |||  |||");
            Console.WriteLine("     |||      ||||||| |||      ||   || |||   ||| |||  ||| ||| | ||| ||| |||      |||  |||");
            Console.WriteLine("     |||              |||      ||   || |||   ||| |||  ||| |||  |||| ||| |||      ||||||||");
            Console.WriteLine("     |||              |||      ||   || |||   ||| |||  ||| |||  |||| ||| |||      |||  |||");
            Console.WriteLine("     |||              |||||||| ||||||| |||   ||| |||||||| |||   ||| ||| |||||||| |||  |||\n\n");
        }
    }
}
