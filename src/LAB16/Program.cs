using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class LAB16
{
    class BankAccount
    {
        private int balance = 0;
        private readonly object balanceLock = new object();

        public async Task DepositAsync(int amount)
        {
            await Task.Delay(100);
            lock (balanceLock)
            {
                balance += amount;
                Console.WriteLine($"Депозит +{amount} грн");
            }
        }

        public async Task WithdrawAsync(int amount)
        {
            await Task.Delay(100);
            lock (balanceLock)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Знято -{amount} грн");
                }
                else
                {
                    Console.WriteLine($"Недостатньо коштів для зняття -{amount} грн");
                }
            }
        }

        public int GetBalance()
        {
            lock (balanceLock)
            {
                return balance;
            }
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            BankAccount account = new BankAccount();
            List<Task> tasks = new List<Task>
            {
                account.DepositAsync(200),
                account.WithdrawAsync(100),
                account.DepositAsync(300),
                account.WithdrawAsync(50)
            };

            await Task.WhenAll(tasks);
            Console.WriteLine($"Кінцевий баланс: {account.GetBalance()} грн");
        }
    }
}
