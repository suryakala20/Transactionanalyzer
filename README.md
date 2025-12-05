.Net Task1 - Datatypes
1. A fintech company is building a Credit Card Transaction Analyzer. Developers must process transaction details with the correct C# datatypes to ensure accuracy, security, and performance.
Question
You are given the following transaction details:
•	Transaction ID → alphanumeric, 12 characters
•	Amount → can be up to ₹10,00,000.75
•	IsInternational → True if the transaction is made outside India
•	CustomerRating → value between 0.0 and 5.0 (precision up to 2 decimal places)
•	TransactionTimestamp → date and time of the transaction
•	RewardPoints → whole number (may reach up to millions)
Task:
1.	Choose the most appropriate C# datatype for each field.

2.	Write a small C# code snippet declaring all these variables with sample values.

Task:
2. You are working in a software company developing a Device Health Monitoring System for a smart factory.
The project contains multiple modules, and the build system should decide which module will run based on configuration.
Currently, the solution contains two classes, each with a Main() method:
using System;

namespace DeviceMonitor
{
    class TemperatureModule
    {
        public static void Main(string[] args)
        {
            //Your Code here
        }
    }
    class VibrationModule
    {
        public static void Main()
        {
            //Your code here
        }
    }
}

Modify the above program so that:

1.	TemperatureModule.Main() becomes the startup entry point
2.	VibrationModule.Main() is converted into a normal helper method
3.	Show the corrected code

