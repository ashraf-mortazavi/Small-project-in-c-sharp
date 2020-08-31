using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
   public  class BankAccont
    {
        public string  Number {get;}
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in alltransection)
                {
                    balance += item.Amount;
                }
                return balance; 
            }
                   
                
          }

        private static int accountnumber = 123456789;

        private List<Transaction> alltransection = new List<Transaction>();
        public BankAccont(string name, decimal initialbalance)
        {
            this.Owner = name;
            Makedeposit(initialbalance, DateTime.Now, "save initialbalance as the deposit");
            this.Number = accountnumber.ToString();
            accountnumber++;
        }

        public void Makedeposit (decimal amount, DateTime date, string note)
        {
            if (amount <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "amount of deposite must be positive"); 
            }
            var deposite = new Transaction(amount, date, note);
            alltransection.Add(deposite);
        }
        public void MakeWitheral (decimal amount, DateTime date, string note)
        {
         if(amount <=0 )
            {
                throw new ArgumentOutOfRangeException (nameof(amount), "amount of witheral must be positive");

            }
         if (Balance - amount <0)
            {
                throw new InvalidOperationException("Not Sufficient funds for this witherwal");
            }
            var witheral = new Transaction(-amount, date, note);
            alltransection.Add(witheral);

        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            // Header 
            report.AppendLine("Date\t Amount \t Note");

            //ROWS
            foreach (var item in alltransection)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t {item.Amount} \t {item.Notes}");
            }

            return report.ToString();
        
        }
       
    }
}
