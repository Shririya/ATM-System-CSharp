using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = 1234;
            Console.Write("Please enter your PIN:");
            if(pin == Convert.ToInt32(Console.ReadLine()))
            {
                Console.WriteLine("PIN accepted. Access granted.");
            }
            else
            {
                Console.WriteLine("Invalid PIN. Access denied.");
                return;
            }
            int balance = 1000;
            while (true)
            {
                Console.WriteLine("Welcome to ATM");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Exit");
                Console.Write("Please select an option:");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Balance: $" + balance);
                        break;
                    case "2":
                        try
                        {
                            Console.Write("Enter amount:");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            balance += amount;
                            Console.WriteLine("Amount deposited: $" + amount);
                            Console.WriteLine("New balance: $" + balance);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.Write("Enter amount:");
                            int withdrawAmount = Convert.ToInt32(Console.ReadLine());

                            if (withdrawAmount > balance)
                            {
                                Console.WriteLine("Insufficient funds.");
                            }
                            else
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine("Amount withdrawn: $" + withdrawAmount);
                                Console.WriteLine("New balance: $" + balance);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }


        }
        }
    }

