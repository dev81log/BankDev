using System;
using System.Collections;
using Array = System.Array;

namespace BankDev
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Window();
            Menu();
        }

        private static void Window()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("*** BankDev - Electronic Terminal ****");
            Console.WriteLine("**************************************");
            
            AccountList();

            Console.WriteLine("1 - Balance");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - Exit Service");
        }

        private static void Menu()
        {
            var choiceInput = short.Parse(Console.ReadLine() ?? string.Empty);

            switch (choiceInput)
            {
                case 1:
                    Console.WriteLine("Balance");
                    break;
                case 2:
                    Console.WriteLine("Withdraw");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    return;
            }
        }

        private static void Operations()
        {
        }

        private static ArrayList ListUser()
        {
            var accountList = new ArrayList
            {
                22,
                "Robert",
                true
            };
            return accountList;
        }

        private static void AccountList()
        {
            var client = ListUser();
            Console.WriteLine($"Welcome {client[1]} to id {client[0]} and service {client[2]}");

        }

        struct AccountListClient
        {
            public int ClientId { get; set; }
            public string ClientName { get; set; }
        }
    }
}
