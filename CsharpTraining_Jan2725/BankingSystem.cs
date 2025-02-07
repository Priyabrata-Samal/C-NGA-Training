using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpTraining_Jan2725
{
    public class BankingSystem
    {
        public string BankName = "Rexis Bank";
        public float InterestRate = 5 / 100.0f;
        public string BankLoc = "Barcelona";
    }
    public class Candidate : BankingSystem
    {
        public string Name;
        public double Balance;
        int _AccountNumber;

        public Candidate(string name, double balance, int accountNumber)
        {
            this.Name = name;
            this.Balance = balance;
            this._AccountNumber = accountNumber;
        }

        public  int AccountNumber
        {
            get { return _AccountNumber; }
        }
    }
    public class Transaction : Candidate
    {
        public Transaction(string name, double balance, int accountNumber) : base(name, balance, accountNumber) { }
        public void Transactions(int mpin)
        {
            Console.WriteLine($"Welcome {base.Name} to the {BankName} Do you want to continue type Yes or No");
            string? concent = Console.ReadLine();
            while(concent == "Yes")
            {
                if (base.AccountNumber == 907856342 && mpin == 200209)
                {
                    Console.WriteLine("Please eneter the querry to proceed with your transaction request Press 1 = check, Press 2 = Withdraw, Press 3 = Credit ");
                    int querry = Convert.ToInt32(Console.ReadLine());
                    switch (querry)
                    {
                        case 1:
                            Console.WriteLine("Your current available balance is: " + base.Balance);
                        break;

                        case 2:
                            Console.WriteLine("Enter the amount that you want to withdraw from your account");
                            double withdraw = Convert.ToDouble(Console.ReadLine());
                            if (withdraw > base.Balance)
                            {
                                Console.WriteLine("Insufficient Balance in your account");
                            }
                            else
                            {
                                double amount = base.Balance - withdraw;
                                Console.WriteLine($"The remaining balance in the account is {amount}");
                                base.Balance = amount;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the amount that you want to credit in your account");
                            double credit = Convert.ToDouble(Console.ReadLine());
                            double Totalamount = base.Balance + credit;
                            Console.WriteLine($"Your Current available balance in your account is {Totalamount}");
                            base.Balance = Totalamount;
                            break;
                        default:
                            Console.WriteLine("INVALID QUERRY REQUEST");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("INVALID CREDENTIALS");
                }
                Console.WriteLine("Do you still want to continue ? type Yes or No");
                concent = Console.ReadLine();
            }
            Console.WriteLine($"Thank You for visiting {base.Name}");
        }
    }
    public class FixDeposit : BankingSystem
    {
        public void TotalInterest(double principal, int timesCompounded, int years)
        {
            double amount = principal * Math.Pow((1 + base.InterestRate / timesCompounded), timesCompounded * years);
            Console.WriteLine($"Your Compund interest rate: {amount}");
        }
    }
    public class Mains
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started");
            BankingSystem bank = new BankingSystem();
            Console.WriteLine($"Hi Welcome to the {bank.BankName}");
            Console.WriteLine("Dear coustomer please Enter your choice, Press 1 for proceed with your transactions request or Press 2 for Fix Deposit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 1:
                    Console.WriteLine("Please enter the user name");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Please enter your balance");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter your account number");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    Transaction tran = new Transaction(name, balance, accountNumber);
                    Console.WriteLine("Enter your MPIN");
                    int mpin = Convert.ToInt32(Console.ReadLine());
                    tran.Transactions(mpin);
                break;
                case 2:
                    FixDeposit fix = new FixDeposit();
                    Console.WriteLine("Enter the principal amount");
                    double principal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enetr the time it will be compunded");
                    int time = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter total year");
                    int year = Convert.ToInt32(Console.ReadLine());
                    fix.TotalInterest(principal, time, year);
                break;
            }
            Console.WriteLine("Thank For Visiting, \nProgram ended. "); 
        }
    }
}
