using System;
using System.Collections.Generic;

namespace SydneyCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of customers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<string> name = new List<string>();
            List<int> quantity = new List<int>();
            List<string> reseller = new List<string>();
            List<double> charge = new List<double>();

            double price;
            double min = 99999999;
            string minName = "";
            double max = -1;
            string maxName = "";

            Console.WriteLine("\n\t\t*** Welcome to Sydney Coffee Program ***\n");

            for (int i = 0; i < n; i++)
            {
                // CHANGE 1: Name validation
                string tempName;
                do
                {
                    Console.Write("Enter customer name: ");
                    tempName = Console.ReadLine().Trim();
                    if (tempName == "")
                        Console.WriteLine("Name cannot be empty. Try again.");
                } while (tempName == "");
                name.Add(tempName);

                int q = 0;
                do
                {
                    Console.Write("Enter number of coffee bean bags (1–200): ");
                    q = Convert.ToInt32(Console.ReadLine());
                    if (q < 1 || q > 200)
                        Console.WriteLine("Invalid input! Enter between 1 and 200.");
                } while (q < 1 || q > 200);

                quantity.Add(q);

                if (q <= 5)
                    price = 36 * q;
                else if (q <= 15)
                    price = 34.5 * q;
                else
                    price = 32.7 * q;

                string tempReseller;
                do
                {
                    Console.Write("Are you a resell
