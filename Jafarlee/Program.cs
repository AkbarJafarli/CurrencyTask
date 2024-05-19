using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Transactions;
using System.Xml;

namespace Jafarlee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //===============================================================================================
            //===============================================================================================


            //decimal commonPayment = 0;
            //string brandName;

            //while (true)
            //{


            //    while (true)
            //    {
            //        Console.Write("Brand: ");
            //        brandName = Console.ReadLine();

            //        if (brandName == "Adidas" || brandName == "Nike" || brandName == "Puma")
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please choose correct brand");
            //        }

            //    }



            //    Console.Write("Category: ");
            //    string category = Console.ReadLine();
            //    Console.Write("Size: ");
            //    int size = int.Parse(Console.ReadLine());
            //    Console.Write("Price: ");
            //    decimal price = decimal.Parse(Console.ReadLine());

            //    while (true)
            //    {
            //        Console.Write("Count: ");
            //        int count = int.Parse(Console.ReadLine());

            //        if (count > 0 && count < 100)
            //            break;
            //        else
            //        {
            //            Console.WriteLine("Please choose correct count");
            //        }




            //        decimal total = price * count;
            //        Console.WriteLine($"Brand: {brandName}, Category: {category}, Size: {size}, Price: {price}, Count: {count} Total:{total}");

            //        Console.WriteLine("=================");
            //        Console.WriteLine("Payment");
            //        Console.WriteLine(total);
            //        Console.WriteLine("=================");

            //        Console.WriteLine("Do you want new order?");
            //        string ClientsAnswer = Console.ReadLine();

            //        commonPayment = commonPayment + total;


            //        if (ClientsAnswer == "No")
            //        {
            //            break;

            //        }



            //    }

            //}
            //Console.WriteLine("================================");
            //Console.WriteLine("Common Payment: "+ commonPayment);




            //==========================================================================================================================================================

            //decimal commonPayment = 0;
            //decimal count;
            //decimal price;
            //string brandName;
            //string color;


            //while (true)
            //{

            //    while (true)
            //    {
            //        Console.Write("Brand: ");
            //        brandName = Console.ReadLine();
            //        if (brandName == "Lacoste" || brandName == "Givenchy" || brandName == "Prada")
            //        {
            //            break;
            //        }else
            //        {
            //            Console.WriteLine("We have only Lacoste,Givenchy,Prada");
            //        }
            //    }
            //    Console.Write("Category: ");
            //    string category = Console.ReadLine();
            //    Console.Write("Size: ");
            //    int size = int.Parse(Console.ReadLine());

            //    while (true)
            //    {
            //        Console.Write("Color: ");
            //        color = Console.ReadLine();
            //        if ( color == "Black" || color == "Blue" || color == "Brown")
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Black,Blue,Brown colors are currently available");
            //        }
            //    }

            //    while (true)
            //    {
            //        Console.Write("Price: ");
            //        price = decimal.Parse(Console.ReadLine());
            //        if (price > 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please insert correct price");
            //        }
            //    }

            //    while (true)
            //    {
            //        Console.Write("Count: ");
            //        count = int.Parse(Console.ReadLine());
            //        if (count>0 && count < 100)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please choose correct count");
            //        }
            //    }
            //    decimal currentPayment = price * count;
            //    Console.WriteLine($"Brand: {brandName}, Category: {category}, Size: {size},Color: {color}, Price: {price}, Count: {count}, Current Payment : {currentPayment}");
            //    Console.WriteLine("Do you want new order? (Yes,No)");
            //    string clientsAnswer = Console.ReadLine();
            //    commonPayment = commonPayment + currentPayment;
            //    if (clientsAnswer == "No")
            //    {
            //        break;
            //    }



            //}
            //       Console.WriteLine("Common Payment: " + commonPayment);


            //==============================================================================================================


            //string[] names = { "Mahmood,Eldar,Aslan" };
            //int Idx = 0;
            //while (Idx < names.Length)
            //{
            //    string name = names[Idx];
            //    if (name == "Eldar")
            //    {
            //        Console.WriteLine("huwhd");
            //        break;
            //    }

            //}

            //=================================

            //Array daxilinde elementlerin toplanmasi

            //decimal[] prices = { 9888.2M, 54, 123, 87 };
            //int idx = 0;
            //decimal sum = 0;
            //while (idx < prices.Length)
            //{
            //    sum=sum+ prices[idx];
            //    idx=idx+1;
            //}
            //Console.WriteLine(sum);

            //Array daxilinde cut ededlerin cemi

            //int[] numbers = { 11, 12, 13, 14, 15, };
            //int idx = 0;
            //int sum = 0;
            //while(idx < numbers.Length)
            //{
            //    if (numbers[idx] % 2 == 0)
            //    {
            //        sum = sum + numbers[idx];
            //    }

            //        idx = idx + 1;


            //}
            //    Console.WriteLine(sum);

            //Array daxilinde tek ededlerin tapilmasi

            //int[] numbers = { 20, 21, 22, 23, 24, 25, 26, };
            //int idx = 0;
            //int sum = 0;
            //while (idx < numbers.Length)
            //{

            //}



            //=======================================================


            //int a = 5;
            //string name = "Akbar";
            //string[] names = { "Akbar", "Jake", "Tyson" };
            //int[] numbers = new int[5];
            //numbers[0] = 2;
            //numbers[1] =3;
            //numbers[2] = 4;
            //numbers[3] = 5;
            //numbers[4] = 6;


            //int[] numbers = { 2, 23, 34, 45, 57, 78, 89, 90, 12, 22, 13, 14 };
            //int lastIdx = numbers.Length - 1; // 11

            //int firstIdx = 0;
            //while (true)
            //{
            //    Console.WriteLine(numbers[firstIdx]);
            //    if (firstIdx == lastIdx)
            //    {
            //        break;
            //    }
            //    firstIdx = firstIdx + 1;
            //}


            //=======================================================
            //decimal[] prices = { 9888.2M, 54, 123, 87 };
            //int idx = 0;
            //decimal sum = 0;
            //while (idx < prices.Length)
            //{
            //    sum=sum+ prices[idx];
            //    idx=idx+1;
            //}
            //Console.WriteLine(sum);


            //decimal[] numbers = { 22.5M, 15, 75, 20, 46 };
            //int firstIdx = 0;
            //decimal sum = 0;
            //while(firstIdx < numbers.Length)
            //{
            //    sum = sum + numbers[firstIdx];
            //    firstIdx = firstIdx + 1;
            //}
            //Console.WriteLine(sum);


            //decimal[] numbers = { 15, 56, 67, 78, 20, 22.6M };
            //int firstIdx = 0;
            //decimal sum = 0;
            //while (firstIdx < numbers.Length)
            //{
            //    sum= sum + numbers[firstIdx];
            //    firstIdx= firstIdx+1;
            //}

            //=============================================================================
            //=============================================================================



            // 1. İstifadəçi iki ədəd daxil edir. ( X və Y ) Əgər X
            //Y - ə qalıqsız bölünürsə ekrana Yes çıxır, əks
            //halda No.

            //int a;
            //int b;
            //Console.WriteLine("Insert first number");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insert second number");
            //b= int.Parse(Console.ReadLine());
            //if(a%b == 0)
            //{
            //    Console.WriteLine("Yes");
            //}else
            //{
            //    Console.WriteLine("No");
            //}

            //=============================================================================
            //=============================================================================


            //int[] numbers = { 12, 13, 14, 15, 16 };
            //int idx = 0;
            //int sum = 0;
            //while (idx < numbers.Length)
            //{
            //    sum = sum + numbers[idx];
            //    idx = idx + 1;
            //}
            //Console.WriteLine(sum);

            //=================================================
            //=================================================


            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int lastIdx = numbers.Length - 1;
            //int firstIdx = 0;
            //Array.Reverse<int>(numbers);
            //while (true)
            //{
            //    Console.WriteLine(numbers[firstIdx]);      
            //    if (firstIdx == lastIdx)
            //    {
            //        break;
            //    }
            //    firstIdx = firstIdx + 1;

            //}

            //==================================================
            //==================================================
            //int[] numbers = { 21, 22, 23, 23, 25, 26, 27, 28, 29, };
            //int idx = 0;
            //int sum = 0;
            //while (idx < numbers.Length)
            //{
            //    if (numbers[idx] % 2 == 0)
            //    {
            //        sum = sum + numbers[idx];

            //    }
            //        idx = idx + 1;

            //}

            //Console.WriteLine(sum);

            //====================================================
            //====================================================

            //int[] numbers = { 12, 13, 14, 15, 16, 17, 18 };
            //int idx = 0;
            //int sum = 0;
            //while ( idx < numbers.Length)
            //{
            //    if (numbers[idx]%2 == 1)
            //    {
            //        sum = sum + numbers[idx];
            //    }
            //    idx = idx + 1;
            //}
            //Console.WriteLine(sum);

            //======================================================
            //======================================================

            //int[] numbers = { 10, 13, 14, 15, 20, 23, 25, 27, 30, 32, 35 };
            //int idx = 0;
            //int sum = 0;
            //while (idx < numbers.Length)
            //{
            //    if (numbers[idx] % 5 == 0)
            //    {
            //        sum = sum + numbers[idx];
            //    }
            //    idx = idx + 1;
            //}
            //Console.WriteLine(sum);

            //======================================================
            //======================================================

            //0,1,1,2,3,5,8
            //int num1 = 0;
            //int num2 = 1;
            //int num3;
            //Console.WriteLine(num1 + " ");
            //Console.WriteLine(num2 + " ");
            //while (true)
            //{
            //    num3 = num1 + num2;
            //    Console.WriteLine(num3);    
            //    num1= num2; num2=num3;
            //    Console.ReadLine();
            //}

            //======================================================
            //Array daxilindekileri ekrana cxarilmasi

            //string[] names = { "Akbar", "Asiman", "Mahmood" };
            //int firstIdx = 0;
            //int lastIdx = names.Length - 1;
            //while (true)
            //{
            //    Console.WriteLine(names[firstIdx]);
            //    firstIdx++;
            //    if (firstIdx > lastIdx)
            //    {
            //        break;
            //    }
            //}


            //======================================================
            //Array daxilinde max ededin tapilmasi

            //int[] numbers = { 11, 22, 33, 44, 55, 66 };

            //int maxNum = numbers[0];
            //int Idx = 0;
            //while (Idx < numbers.Length)
            //{
            //    if (maxNum > numbers[Idx])
            //    {
            //        maxNum = numbers[Idx];
            //    }

            //    Idx = Idx + 1;
            //}

            //Console.WriteLine(maxNum);


            //======================================================
            // Verilen araliqda ededlerin ceminin tapilmasi

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //int firstIdx = 0;
            //int sum = 0;
            //while(firstIdx < numbers.Length)
            //{
            //    sum = sum + numbers[firstIdx];
            //    firstIdx++;

            //}
            //Console.WriteLine(sum);

            //=====================================================
            //Array daxilinde ededlerin ortalamasinin tapilmasi
            //int[] numbers = { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12 };
            //int firstIdx = 0;
            //decimal sum = 0;
            //decimal middleNum = 0;
            //while (firstIdx < numbers.Length)
            //{
            //    sum = sum + numbers[firstIdx];
            //    firstIdx++;
            //}
            //middleNum = sum / numbers.Length;

            //Console.WriteLine(middleNum);


            //=====================================================

            //Arrayin tersinin tapilmasi
            //int[] num = { 1, 2, 3, 4, 5, 6, };
            //int firstIdx = 0;
            //int lastIdx = num.Length - 1;
            //Array.Reverse<int>(num);
            //while (true)
            //{
            //    Console.WriteLine(num[firstIdx]);
            //    if (firstIdx == lastIdx)
            //    {
            //        break;
            //    }
            //    firstIdx++;
            //}

            //========================================================


            // Array icende daxil edilen ededin var olub olmamasi

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //Console.WriteLine("Deyer daxil edin");
            //int inputNum = int.Parse(Console.ReadLine());
            //int firstIdx = 0;
            //bool result = true;
            //while (firstIdx < numbers.Length)
            //{
            //    if (numbers[1] == inputNum)
            //    {
            //        result = true;
            //    }

            //    firstIdx++;

            //    Console.WriteLine(result);

            //}

            //====================================================
            //====================================================

            //Array daxilinde ededlerin ardicil olub olmamagi

            //int[]numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int Idx = 0;
            //bool isSorted = true;
            //while(Idx < numbers.Length-1)
            //{
            //    if (numbers[Idx] > numbers[Idx+1])
            //    {
            //        isSorted = false;
            //        break;
            //    }
            //    Idx++;
            //}

            //Console.WriteLine(isSorted);

            //==================================================
            //==================================================
            // Min ve max yerini deyisdirilmesi

            //int[]numbers = { 9, 12, 21, 56, 67, 6, 100, 58, 98 };
            //int max = numbers[0];
            //int min = numbers[0];
            //int Idx = 0;
            //while(Idx < numbers.Length)
            //{
            //    if (max < numbers[Idx])
            //    {
            //        max = numbers[Idx];
            //    }
            //    if (min > numbers[Idx])
            //    {
            //        min = numbers[Idx];
            //    }
            //    Idx++;

            //}
            //Idx = 0;
            //while( Idx < numbers.Length)
            //{
            //    if (numbers[Idx]== max)
            //    {
            //        numbers[Idx] = min;
            //    }
            //    else if (numbers[Idx] == min)
            //    {
            //        numbers[Idx]= max;
            //    }
            //    Idx++;
            //}

            //Idx = 0;
            //while( Idx < numbers.Length)
            //{
            //    Console.Write(numbers[Idx]+" ");
            //    Idx++;  
            //}
            //====================================================
            //// Min ve max tapilmasi

            //int[] numbers = { 9, 12, 21, 56, 67, 6, 100, 58, 98 };
            //int max = numbers[0];
            //int min = numbers[0];
            //int Idx = 0;
            //while (Idx < numbers.Length)
            //{
            //    if (max < numbers[Idx])
            //    {
            //        max = numbers[Idx];
            //    }
            //    if (min > numbers[Idx])
            //    {
            //        min = numbers[Idx];
            //    }
            //    Idx++;

            //}
            //Console.WriteLine(max);

            //==================================================================
            //==================================================================

            Console.WriteLine("Show recent currency rates");
            Console.ReadLine();
            string[] currency = { "USD", "EUR", "AED", "TRY", "CZK", "CNY", "IRR", "CAD", "MXN", "UAH" };
            int firstIdx1 = 0;
            int lastIdx1 = currency.Length - 1;
            decimal[] rates = { 1.7000M, 1.8455M, 0.4628M, 0.0527M, 0.0748M, 0.2352M, 0.0040M, 1.2477M, 0.1017M, 0.0432M };
            int firstIdx2 = 0;
            int lastIdx2 = rates.Length - 1;
            while (true)
            {
                Console.WriteLine(currency[firstIdx1] + "= " + rates[firstIdx2]);
                firstIdx1++;
                firstIdx2++;
                if (firstIdx1 > lastIdx1 & firstIdx1 > lastIdx2)
                {
                    break;
                }
            }
            string currencyCode;
            string[] Cods = { "USD", "EUR", "AED", "TRY", "CZK", "CNY", "IRR", "CAD", "MXN", "UAH" };
            int firstCodsIdx = 0;
            decimal[] codsRates = { 1.7000M, 1.8455M, 0.4628M, 0.0527M, 0.0748M, 0.2352M, 0.0040M, 1.2477M, 0.1017M, 0.0432M };
            int codsRatesIdx = 0;
            Console.WriteLine("Find currency rate by code ");
            currencyCode = Console.ReadLine();
            while (firstCodsIdx < Cods.Length - 1)
            {
                if (currencyCode == Cods[firstCodsIdx])
                {
                    Console.WriteLine(Cods[firstCodsIdx] + "= " + codsRates[codsRatesIdx]);
                    break;
                }
                else
                {
                    firstCodsIdx++;
                    codsRatesIdx++;
                }
            }
            if (firstCodsIdx == Cods.Length - 1)
            {
                Console.WriteLine("This exchange rate was not found in the system");
            }


        }
    }
}
