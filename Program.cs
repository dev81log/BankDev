namespace BankDev
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Window();
            UserPassSystem();
            Menu();
        }

        private static void Window()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("*** BankDev - Electronic Terminal ****");
            Console.WriteLine("**************************************");
        }

        private static void Menu()
        {
            Console.WriteLine("*** Choice under one options below ***");
            Console.WriteLine("1 - Balance");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - Exit Service");

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

        private static void UserPassSystem()
        {
            var contestPass = true;

            while (contestPass)
            {
                Console.Write("Insert idUserPass: ");
                var idUserPass = int.Parse(Console.ReadLine() ?? string.Empty);

                if (idUserPass == GetUserAccount().Id)
                {
                    Console.WriteLine($"User pass account successful {GetUserAccount().Name}");
                    contestPass = false;
                }
                else
                {
                    Console.WriteLine("Not user account registered");
                }
            }
        }

        private static void Operations()
        {
        }

        private static UserAccount GetUserAccount()
        {
            var userAccount = new UserAccount
            {
                Id = 2233,
                Name = "Robert",
                Amount = 3.600f,
                CreatedOn = DateTime.Now,
                Status = true
            };

            return userAccount;
        }

        private static void AccountList()
        {
            var client = GetUserAccount();
            Console.WriteLine(
                $"Welcome {client.Name} to id {client.Id} and service {client.Status} registered {client.CreatedOn}");
        }
    }

    internal class UserAccount
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public double Amount { get; init; }
        public DateTime CreatedOn { get; init; }
        public bool Status { get; init; }
    }
}