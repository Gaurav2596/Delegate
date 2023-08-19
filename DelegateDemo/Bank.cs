using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo

{ 
    public delegate void DelegateDemo();
    public class Bank
    {
        public event DelegateDemo InsufficientBalance;
        public event DelegateDemo LowBalance;
        public event DelegateDemo ZeroBalance;
        public int balance;
        public Bank(int balance)
        {
            this.balance = balance;
        }
        public void Debit(int amount)
        {

            if(amount>balance)
            {
                InsufficientBalance();
            }
            
            else if(amount < balance)
             {
                balance -= amount;
                if (balance == 0)
                {
                    ZeroBalance();
                }
                else if (balance < 3000)
                {
                    LowBalance();
                }

                

            }
            
        }
        public void Credit(int amount)
        {
            balance += amount;
        }
        public override string ToString()
        {
            return $"{balance}";
        }
    }
}
