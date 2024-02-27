using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threadd
{
     class BankAccount
    {
        private Object acctLock = new object();
        double Balance { get; set; }
        string Name { get; set; }

        public BankAccount(double bal)
        {
            Balance = bal;
        }


        public double Withdraw(double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in your Account");
                return Balance;
            }

            lock (acctLock)
            {//lock => whenever a thread is executing lock is going to block another thread from executing until the other tread isdone
                if (Balance >= amt)
                {
                    Console.WriteLine("Removed {0}, now you have {1} in your account",amt,(Balance-amt));
                   Balance -= amt;
                }
            }
            return Balance;
        }

        public void IssueWithdraw()
        {
            Withdraw(1);
       
        }
    }
}
