using System;
class Program
{
    static void Main()
    {
        string transactionID = "b764pkabc23x";
        Console.WriteLine("Transaction ID: " + transactionID);
        decimal amount = 1000000.75m;
        Console.WriteLine("Amount: " + amount);
        bool isInternational = true;
        Console.WriteLine("International: " + isInternational);
        decimal customerRating = 2.67m;
        Console.WriteLine("Customer Rating: " + customerRating);
        DateTime transactionTimestamp = DateTime.Now;
        Console.WriteLine("Timestamp: " + transactionTimestamp);
        int rewardPoints = 200000;
        Console.WriteLine("Reward Points: " + rewardPoints);

    }
}
