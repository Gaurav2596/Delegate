using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Program
    {
        static void InsufficientBalance()
        {
            Console.WriteLine("Insufficient balance");
        }
        static void LowBalance()
        {
            Console.WriteLine("Low balance");
        }
        static void ZeroBalance() 
        {
            Console.WriteLine("Zero balance");
        }
        static void Main(string[] args)
        {
            //Calculation c = new Calculation();
            //Mydelegate my = new Mydelegate(c.Add); //c.Add-->added method reference

            ////+= add ref in invocation list
            ////-= remove method ref from invocation list
            ////my -= new Mydelegate(c.Sub);
            //my += new Mydelegate(c.Sub);  // adding another ref / adding ref for sub()

            //Delegate[] list=my.GetInvocationList();

            //foreach(Delegate item in list)
            //{
            //    Console.WriteLine(item.Method);
            //    Console.WriteLine(item.DynamicInvoke(45, 22));

            //}


            //Console.WriteLine(my.Invoke(15,25));

            //Test t1 = new Test();
            //Delegate1 d1 = new Delegate1(t1.Acceptdetails);
            //d1.Invoke(101,"gaurav",40000);

            Bank b = new Bank(5000);
            b.InsufficientBalance += new DelegateDemo(InsufficientBalance);
            b.LowBalance += new DelegateDemo(LowBalance);
            b.ZeroBalance += new DelegateDemo(ZeroBalance);

            Console.WriteLine(b.ToString());
            b.Debit(3000);
            Console.WriteLine(b.ToString());
            b.Credit(5000);
            Console.WriteLine(b.ToString());
        }
    }
}
