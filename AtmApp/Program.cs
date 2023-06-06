using System;

class Program
{
    static void Main()
    {
        float balance = 1000.00f;
        int option;
        float amount;


        while(true)
        {
            Console.WriteLine("\n**** ATM Transaction ****");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Quit");
            Console.WriteLine("*************************");

            Console.Write("Enter your option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Your balance: ${0:f2}", balance);
                    break;

                case 2:
                    Console.Write("Enter the amount you'd like to withdraw: $");
                    amount = float.Parse(Console.ReadLine());
                    if (amount > balance)
                    {
                        Console.WriteLine("Insufficient balance. Withdrawal has been canceled.");
                    }
                    else
                    {
                        balance -= amount;
                        Console.WriteLine("Withdrawal of ${0:f2} successful. Remaining balance is: ${1:f2}", amount, balance);
                    }

                    break;

                case 3:
                    Console.Write("Enter the amount to deposit: $");
                    amount = float.Parse(Console.ReadLine());
                    balance += amount;
                    Console.WriteLine("Deposit of ${0:f2} is now successful. Updated balance is: ${1:f2}", amount, balance);
                    break;

                case 4:
                    Console.WriteLine("Thank you for using this ATM!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}