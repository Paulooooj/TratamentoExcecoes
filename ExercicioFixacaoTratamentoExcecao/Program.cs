using ExercicioFixacaoTratamentoExcecao.Entities;
using ExercicioFixacaoTratamentoExcecao.Entities.Exceptions;
using System.Globalization;

namespace ExercicioFixacaoTratamentoExcecao

{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account ac = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                    ac.Withdraw(withdraw);
                Console.WriteLine("New balance: " + ac.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}