using ExercicioFixacaoTratamentoExcecao.Entities.Exceptions;
using System;


namespace ExercicioFixacaoTratamentoExcecao.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
           
            if(amount > WithDrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if (Balance == 0.0 || Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
