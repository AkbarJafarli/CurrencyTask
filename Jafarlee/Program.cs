using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Xml;

namespace Jafarlee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1) Show recent currency rates.");
                Console.WriteLine("2) Find currency rate by code.");
                Console.WriteLine("3) Calculate amount by currency.");
                Console.WriteLine("4) Exit.");


                Console.WriteLine();
                Console.Write("Select:");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    string[] currencyCodes = { "USD", "EUR", "AED", "CZK", "CNY", "CAD", "MXN", "RUB", "TRY", "UAH" };
                    int currencyCodesIdx = 0;
                    decimal[] currencyRates = { 1.7000M, 1.8455M, 0.4628M, 0.0748M, 0.2352M, 1.2477M, 0.1017M, 0.0187M, 0.0527M, 0.0432M };
                    int currencyRatesIdx = 0;
                    while (currencyCodesIdx < currencyCodes.Length)
                    {
                        Console.WriteLine(currencyCodes[currencyCodesIdx] + "= " + currencyRates[currencyRatesIdx]);
                        currencyCodesIdx++;
                        currencyRatesIdx++;
                        if (currencyCodesIdx > currencyCodes.Length - 1)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("");
                    Console.Write("Enter to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                }


                else if (choice == 2)
                {

                    Console.Write("Enter the currency:");
                    string codes = Console.ReadLine();
                    string[] currencyCodes2 = { "USD", "EUR", "AED", "CZK", "CNY", "CAD", "MXN", "RUB", "TRY", "UAH" };
                    int currencyCodesIdx2 = 0;
                    decimal[] currencyRates2 = { 1.7000M, 1.8455M, 0.4628M, 0.0748M, 0.2352M, 1.2477M, 0.1017M, 0.0187M, 0.0527M, 0.0432M };
                    int currencyRatesIdx2 = 0;
                    bool isExist = false;
                    while (currencyCodesIdx2 < currencyCodes2.Length)
                    {
                        if (codes == currencyCodes2[currencyCodesIdx2])
                        {
                            Console.WriteLine(currencyCodes2[currencyCodesIdx2] + "= " + currencyRates2[currencyRatesIdx2]);
                            break;
                        }
                        else
                        {
                            currencyCodesIdx2++;
                            currencyRatesIdx2++;
                        }
                    }
                    if (currencyCodesIdx2 == currencyCodes2.Length)
                    {
                        Console.WriteLine("This exchange rate was not found in the system");
                    }
                    Console.WriteLine("");
                    Console.Write("Enter to the menu...");
                    Console.ReadLine();
                    Console.Clear();

                }

                else if (choice == 3)
                {
                    Console.Write("Enter the amount:");
                    decimal amount;
                    amount = decimal.Parse(Console.ReadLine());
                    string excCode;
                    Console.Write("Enter the exchange rate code:");
                    excCode = Console.ReadLine();
                    string[] lastCodes = { "USD", "EUR", "AED", "CZK", "CNY", "CAD", "MXN", "RUB", "TRY", "UAH" };
                    int lastCodesIdx = 0;
                    decimal[] lastRates = { 1.7000M, 1.8455M, 0.4628M, 0.0748M, 0.2352M, 1.2477M, 0.1017M, 0.0187M, 0.0527M, 0.0432M };
                    int lastRatesIdx = 0;
                    decimal sumAmount;
                    while (lastCodesIdx < lastCodes.Length)
                    {
                        if (excCode == lastCodes[lastCodesIdx])
                        {
                            sumAmount = amount * lastRates[lastCodesIdx];
                            Console.WriteLine(sumAmount);
                            break;
                        }
                        else
                        {
                            lastCodesIdx++;
                            lastRatesIdx++;
                        }
                        Console.WriteLine("");
                        Console.Write("Enter to the menu...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (lastRatesIdx == lastCodes.Length)
                    {
                        Console.WriteLine("This exchange rate was not found in the system");
                    }
                    Console.WriteLine("");
                    Console.Write("Enter to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    return;
                }

            }

        }
    }
}


