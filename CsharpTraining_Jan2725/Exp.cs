using System;

namespace CsharpTraining_Jan2725
{
    // Change delegate to match methods that return void
    public delegate void DemoDeligates();

    public class Account
    {
        int _Cid;
        string _Name;
        double _Balance;
        bool _status;

        public int Cid => _Cid;
        public string Name => _Name;
        public double Balance => _Balance;
        public bool Status
        {
            get => _status;
            set => _status = value;
        }

        public Account(int id, string name, double balance)
        {
            _Cid = id;
            _Name = name;
            _Balance = balance;
        }

        public void Addition()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("The total sum is " + (a + b));
        }

        public void sub()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("The total sub is " + (a - b));
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    Account obj = new Account(24, "John", 50000.00);

        //    // Create delegate and invoke it
        //    DemoDeligates del = new DemoDeligates(obj.sub);
        //    del += new DemoDeligates(obj.Addition);
        //    del(); // Now calls obj.sub() which prints the subtraction

        //    Console.WriteLine("Account ID: " + obj.Cid);
        //    Console.WriteLine("What is your current status? (Enter true or false)");
        //    bool activity;
        //    // Optionally add a TryParse for better error handling
        //    while (!bool.TryParse(Console.ReadLine(), out activity))
        //    {
        //        Console.WriteLine("Invalid input. Please enter true or false:");
        //    }
        //    obj.Status = activity;
        //    Console.WriteLine($"Your current available balance is {obj.Balance}");
        //    Console.WriteLine($"Your name is {obj.Name}");
        //}
    }
}
