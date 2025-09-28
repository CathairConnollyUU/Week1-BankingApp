/*
 * Class Name: Banking App
 * Version 1
 * Author: Cathair Connolly
 */

//Function and methods should be verbs
//With C#, Pascal case should be used with function names
//starting with a capital letter for each word.
//Function names should not have underscores in their names.
using System.Xml.Serialization;

void BuildBankingApp()
{
    //Initialise variable
    //Note that the amount not assigned to the variable
    int choice;
    double depositAmount;
    double accountBalance = 1000.00;

    //Display the main menu screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    //Read users choice menu choice
    //Convert the string to integer
    //using explicit typecasting

    choice = Convert.ToInt32(Console.ReadLine());

    //The || in the loop represents OR
    //which means that a menu choice of 1 or 2
    //is accepted for this logical operationa
    if (choice == 1 || choice == 2)
    {
        //Valid menu choice
        if (choice == 1)
        {
            //Deposit or withdraw funds
            Console.WriteLine("You have chosen to deposit or withdraw funds");
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter amount including pence using decimal point");

            //Typically a currency value is input as a decimal value
            //so the "double" type is required to store the
            //deposit amount.

            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your orignal account balance was {accountBalance}");

            //This line of code is interpreted as
            //account balance = account balance + deposit amount
            //This is an example of an assignment operator
            accountBalance += depositAmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");
        }
        if (choice == 2)
        {
            //View current account information
            Console.WriteLine("You have chosen to view current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
        else 
        {
            //View current account information
            accountBalance = 1000.00;
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
    }
    else
    {
        //Invalid menu choice
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }
}

BuildBankingApp();