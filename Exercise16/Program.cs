﻿using Exercise16.Entities;
using System;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine());

            Account newAccount = new Account(number, holder, balance, limit);
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            newAccount.Withdraw(double.Parse(Console.ReadLine()));

            Console.Write("New Balance: " + newAccount.Balance.ToString("F2"));
            }
                catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
        }
    }
}
