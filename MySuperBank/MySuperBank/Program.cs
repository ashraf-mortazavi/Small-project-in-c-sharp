using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccont("ashraf",2000);
            //var account2 = new BankAccont("amin", 5000);
            //Console.WriteLine($"this account is:{account.Owner} with the value:{account.Balance} and number: {account.Number}");
            //Console.WriteLine($"this is another account:{account2.Owner} with the value :{account2.Balance} and number: {account2.Number}");

            account.Makedeposit(500, DateTime.Now, "jzgjd");
            account.MakeWitheral(250, DateTime.Now, "fhfrtet");
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetAccountHistory());
           

            //try
            //{
            //    account.MakeWitheral(5000, DateTime.Now, "ftyrytyu");

            //}
            //catch (InvalidOperationException e )
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
           
            //try
            //{
            //    var x = new BankAccont("ahmad", -60);
            //}
            //catch (ArgumentOutOfRangeException e )
            //{
            //    Console.WriteLine("Exception cought creating account with negative value");
            //    Console.WriteLine(e.ToString());

            //}

           

        }
    }
}
