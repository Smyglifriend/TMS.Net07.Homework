using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.ConverterCurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input exit if you want to close the program\n\n");
                Console.WriteLine("Input source currency: ");
                var sourceCurrency = Console.ReadLine().ToUpper();
                if (sourceCurrency == "EXIT")
                {
                    Console.WriteLine("You closed the program!");
                    return;
                }
                if (!(sourceCurrency == "USD" || sourceCurrency == "RUB" || sourceCurrency == "EUR" || sourceCurrency == "BYN"))
                {
                    Console.WriteLine("bad input!");
                    return;
                }

                Console.WriteLine("Input target currency: ");
                var targetCurrency = Console.ReadLine().ToUpper();
                if (!(targetCurrency == "USD" || targetCurrency == "RUB" || targetCurrency == "EUR" || targetCurrency == "BYN"))
                {
                    Console.WriteLine("bad input!");
                    return;
                }

                Console.WriteLine("Input amount: ");
                string amount = Console.ReadLine();
                //сделал так, чтобы ввод можно было делать через точку. без этого не работает
                CultureInfo tempCulture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                decimal mainamount = Convert.ToDecimal(amount);
                Thread.CurrentThread.CurrentCulture = tempCulture;

                decimal solution = 0;

                if (sourceCurrency == "USD")
                {
                    if (targetCurrency == "RUB")
                    {
                        solution = mainamount * 75.5051m;
                    }
                    else if (targetCurrency == "EUR")
                    {
                        solution = mainamount * 0.8252m;
                    }
                    else if (targetCurrency == "USD")
                    {
                        solution = mainamount * 1.0000m;
                    }
                    else if (targetCurrency == "BYN")
                    {
                        solution = mainamount * 2.6193m;
                    }
                }
                else if (sourceCurrency == "BYN")
                {
                    if (targetCurrency == "EUR")
                    {
                        solution = mainamount * 0.3150m;
                    }
                    else if (targetCurrency == "BYN")
                    {
                        solution = mainamount * 1.0000m;
                    }
                    else if (targetCurrency == "RUB")
                    {
                        solution = mainamount * 28.8243m;
                    }
                    else if (targetCurrency == "USD")
                    {
                        solution = mainamount * 0.3818m;
                    }
                }
                else if (sourceCurrency == "RUB")
                {
                    if (targetCurrency == "EUR")
                    {
                        solution = mainamount * 0.0109m;
                    }
                    else if (targetCurrency == "BYN")
                    {
                        solution = mainamount * 0.0347m;
                    }
                    else if (targetCurrency == "RUB")
                    {
                        solution = mainamount * 1.0000m;
                    }
                    else if (targetCurrency == "USD")
                    {
                        solution = mainamount * 0.0132m;
                    }
                }
                else if (sourceCurrency == "EUR")
                {
                    if (targetCurrency == "EUR")
                    {
                        solution = mainamount * 1.0000m;
                    }
                    else if (targetCurrency == "BYN")
                    {
                        solution = mainamount * 3.1742m;
                    }
                    else if (targetCurrency == "RUB")
                    {
                        solution = mainamount * 91.4940m;
                    }
                    else if (targetCurrency == "USD")
                    {
                        solution = mainamount * 1.2118m;
                    }
                }
                Console.WriteLine($"{amount} {sourceCurrency} is equal to {solution}  {targetCurrency}\n\n");
                Console.ReadLine();
                Console.Clear();
            }                 
        }       
    }
}

