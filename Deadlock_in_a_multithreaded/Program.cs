using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Deadlock_in_a_multithreaded
{
    public class Account
    {
        double _balance;
        int _id;

        public Account(int id, double balance)
        {
            this._id = id;
            this._balance = balance;
        }
        public int ID
        {
            get { return _id; }
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }
    }
    public class AccountManager
    {
        Account _fromAccount; Account _toAccount; double _amountToTranfer;

        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._fromAccount = toAccount;
            this._amountToTranfer = amountToTransfer;
        }

        public void Transfer()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "trying to aquire lock on " + _fromAccount.ID.ToString());
            lock (_fromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " aquire lock on " + _fromAccount.ID.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " Suspended for 1 second ");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + "Back in action and trying to aquire lock on " + _fromAccount.ID.ToString());
                lock (_toAccount)
                {
                    Console.WriteLine("This code will not be executed");
                    _fromAccount.Withdraw(_amountToTranfer);
                    _toAccount.Deposit(_amountToTranfer);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");

            Account accountA = new Account(102, 5000);
            Account accountB = new Account(103, 3000);

            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";
            
            AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);
            Thread T2 = new Thread(accountManagerB.Transfer);
            T2.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            Console.WriteLine("Main Completed");

            Console.ReadKey();
        }
    }
}
