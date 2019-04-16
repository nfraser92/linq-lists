using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    // Build a collection of customers who are millionaires
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public class BankReport
    {
        public string Name { get; set; }
        public int BankMilionaires { get; set; }
    }

    public class Bank
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }

    public class ReportItem
    {
        public string CustomerName { get; set; }
        public string BankName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.StartsWith("L")
                                          select fruit;

            foreach (string fruit in LFruits)
            {
                // Console.WriteLine($"{fruit}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);

            foreach (int num in fourSixMultiples)
            {
                // Console.WriteLine($"{num}");
            }

            // Order these student names alphabetically, in descending order (Z to A)
            // List<string> names = new List<string>()
            // {
            //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //     "Francisco", "Tre"
            // };

            // List<string> descend = (from name in names
            // orderby name descending
            // select name).ToList();

            // foreach (string name in descend)
            // {
            //     Console.WriteLine($"{name}");
            // }

            // Code below also solves the issue.
            List<string> names = new List<string>()
        {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

            IEnumerable<string> descend = from name in names
                                          orderby name descending
                                          select name;

            foreach (string name in descend)
            {
                // Console.WriteLine($"{name}");
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbersList = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

            IEnumerable<int> ascendingNum = from numb in numbersList
                                            orderby numb ascending
                                            select numb;

            foreach (int numb in ascendingNum)
            {
                // Console.WriteLine($"{numb}");
            }

            // Output how many numbers are in this list
            List<int> numbersList3 = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };
            // Console.WriteLine($"There are {numbersList3.Count()} numbers in the list");

            // How much money have we made?
            List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };
            // Console.WriteLine($"We have made ${purchases.Sum()}.");

            // What is our most expensive product?
            List<double> prices = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };

            // Console.WriteLine($"Our most expensive product is ${prices.Max()}");

            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
        {
            66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
        };

            foreach (int sqn in wheresSquaredo)
            {
                if (Math.Sqrt(sqn) % 1 == 0)
                {
                    // Console.WriteLine($"Square numbers in the list are: {sqn}");
                }
            }

            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            // Build a collection of customers who are millionaires
            IEnumerable<Customer> millionaires = customers.Where(mill => mill.Balance >= 1000000);

            foreach (Customer mill in millionaires)
            {
                // Console.WriteLine($"{mill.Name}'s balance is ${mill.Balance}. They bank with {mill.Bank}.");
            }

            IEnumerable<BankReport> BankMills = (from bank in customers
                                                 group bank by bank.Bank into NewGroup
                                                 // created new class to store names of millionaires and which banks they are at
                                                 select new BankReport
                                                 {
                                                     Name = NewGroup.Key,
                                                     BankMilionaires = NewGroup.Count()
                                                 }).OrderByDescending(bm => bm.BankMilionaires).ToList();

            foreach (BankReport bank in BankMills)
            {
                // Console.WriteLine($"{bank.Name} {bank.BankMilionaires}");
            }

            var results = millionaires.GroupBy(
                   p => p.Bank,
                   (key, g) => new { Bank = key, p = g.Count() });

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Bank} {item.p}");
            }

            // Create some banks and store in a List
            List<Bank> banks1 = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            // Create some customers and store in a List
            List<Customer> newCustomers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            /*
                You will need to use the `Where()`
                and `Select()` methods to generate
                instances of the following class.

            */

            List<ReportItem> millionaireReport = newCustomers
            .Where(cust => cust.Balance >= 1000000)
            .OrderBy(cust => cust.Name.Split(" ")[1])
            .Select(cust => new ReportItem
            {
                CustomerName = cust.Name,
                BankName = banks1.First(bank => bank.Symbol == cust.Bank).Name
                // BankName = banks1.FirstOrDefault(x => x.Symbol == cust.Bank);
            }).ToList();

            foreach (ReportItem item in millionaireReport)
            {
                Console.WriteLine($"{item.CustomerName} at {item.BankName}");
            }
        }
    }
}

