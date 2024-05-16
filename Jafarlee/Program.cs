using System;
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

            decimal commonPayment = 0;
            decimal count;
            decimal price;
            string brandName;
            string color;


            while (true)
            {
                
                while (true)
                {
                    Console.Write("Brand: ");
                    brandName = Console.ReadLine();
                    if (brandName == "Lacoste" || brandName == "Givenchy" || brandName == "Prada")
                    {
                        break;
                    }else
                    {
                        Console.WriteLine("We have only Lacoste,Givenchy,Prada");
                    }
                }
                Console.Write("Category: ");
                string category = Console.ReadLine();
                Console.Write("Size: ");
                int size = int.Parse(Console.ReadLine());
               
                while (true)
                {
                    Console.Write("Color: ");
                    color = Console.ReadLine();
                    if ( color == "Black" || color == "Blue" || color == "Brown")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Black,Blue,Brown colors are currently available");
                    }
                }
                
                while (true)
                {
                    Console.Write("Price: ");
                    price = decimal.Parse(Console.ReadLine());
                    if (price > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please insert correct price");
                    }
                }
                
                while (true)
                {
                    Console.Write("Count: ");
                    count = int.Parse(Console.ReadLine());
                    if (count>0 && count < 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose correct count");
                    }
                }
                decimal currentPayment = price * count;
                Console.WriteLine($"Brand: {brandName}, Category: {category}, Size: {size},Color: {color}, Price: {price}, Count: {count}, Current Payment : {currentPayment}");
                Console.WriteLine("Do you want new order? (Yes,No)");
                string clientsAnswer = Console.ReadLine();
                commonPayment = commonPayment + currentPayment;
                if (clientsAnswer == "No")
                {
                    break;
                }
               


            }
                   Console.WriteLine("Common Payment: " + commonPayment);












































        }
    }
}
