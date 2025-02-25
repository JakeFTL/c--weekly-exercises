/*EXERCISE 1 - BIO
using System.ComponentModel.Design;

string firstName = "Jacob", lastName = "Oliver";
int age = 36;
bool intStudent = false;
int petCount = 1;

Console.WriteLine($"First Name: {firstName}");
Console.WriteLine($"Last Name: {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"International Student? {intStudent}");
Console.WriteLine($"I have {petCount} pet(s)");*/

/*EXERCISE 2 - COMPARISONS
var lilyAge = 37;
var lilyNameLength = ("Lily".Length);
var jakeAge = 36;
var jakeNameLength = ("Jacob".Length);

if (jakeAge > lilyAge)
{
    Console.WriteLine("I am older than Lily.");
    var ageDifference = (jakeAge - lilyAge);
    Console.WriteLine("The age difference is {1}.", ageDifference);
}
else
{
    Console.WriteLine("Lily is older than me.");
    var ageDifference = lilyAge - jakeAge;
    Console.WriteLine("The age difference is {1}.", ageDifference);
}

if (jakeNameLength > lilyNameLength)
{
    Console.WriteLine("My name is longer, {0} letters versus {1} letters.", jakeNameLength, lilyNameLength);
}
else
{
    Console.WriteLine("Her name is longer, {0} letters versus {1} letters.", lilyNameLength, jakeNameLength);
}*/

/*EXERCISE 3 - MONTH/SEASON LOGIC
Console.WriteLine("Select your birthday Month from the list below.");
Console.WriteLine("(1) January\n(2) February\n(3) March\n(4) April\n(5) May\n(6) June\n(7) July\n(8) August\n(9) September\n(10) October\n(11) November\n(12) December");
Console.Write("Enter your birth month (eg: '1' for January): ");
var birthMonth = int.Parse(Console.ReadLine());

switch (birthMonth)
{
    case 12 or 1 or 2:
        Console.WriteLine("Your birthday is in Summer!");
        break;
    case 3 or 4 or 5:
        Console.WriteLine("Your birthday is in Autumn!");
        break;
    case 6 or 7 or 8:
        Console.WriteLine("Your birthday is in Winter!");
        break;
    case 9 or 10 or 11:
        Console.WriteLine("Your birthday is in Spring!");
        break;
}*/

/*EXERCISE 4 - TIMES TABLES
Console.WriteLine("MULTIPLICATION CALCULATOR");
int firstNumber;
int secondNumber;

while (true)
{
    Console.Write("Enter 1st Number (0 - 12): ");
    firstNumber = int.Parse(Console.ReadLine());
    if (firstNumber >= 0 && firstNumber <= 12)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid number, please enter a number between 0 and 12.");
    }
}

while (true)
{
    Console.Write("Enter 2nd Number (0 - 12): ");
    secondNumber = int.Parse(Console.ReadLine());
    if (secondNumber >= 0 && secondNumber <= 12)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid number, please enter a number between 0 and 12.");
    }
}

int result = firstNumber * secondNumber;
Console.WriteLine("Request: {0} x {1}", firstNumber, secondNumber);
Console.WriteLine("Result: {0}", result);*/


/*EXERCISE 5 - DEBUG CODE
using System.Drawing;
using System;

void myFunction()
{
    int myInt = 5;
    Console.WriteLine(myInt);
}

myFunction();*/

/*EXERCISE 6 - DECLARING & USING FUNCTIONS
using System.ComponentModel.Design;

void WelcomeMessage()
{
    Console.WriteLine("*************************");
    Console.WriteLine("Welcome to My Application");
    Console.WriteLine("*************************");
}
WelcomeMessage();*/

/*//EXERCISE 7 - PARAMETERS
void Calculator()
{
    int firstValue, secondValue;

    Console.Write("Enter first value: ");
    while (true)
    {
        try
        {
            firstValue = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid entry, please try again.");
            Console.Write("Enter first value: ");
        }
    }

    Console.Write("Enter second value: ");
    while (true)
    {
        try
        {
            secondValue = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid entry, please try again.");
            Console.Write("Enter second value: ");
        }
    }

    Console.Write("Select Calculation (1: Multiplication - 2: Division): ");
    while (true)
    {
        var calculation = Console.ReadLine();
        if (calculation == "1")
        {
            int result = firstValue * secondValue;
            Console.WriteLine("{0} x {1} = {2}", firstValue, secondValue, result);
            break;
        }
        else if (calculation == "2")
        {
            int result = firstValue / secondValue;
            Console.WriteLine("{0} / {1} = {2}", firstValue, secondValue, result);
            break;
        }
        else
        {
            Console.WriteLine("Invalid selection, please try again.");
            Console.Write("Select Calculation (1: Multiplication - 2: Division): ");
        }
    }
}
Calculator();*/

/*//EXERCISE 8A - SIMPLE NAME
using System.Globalization;

void WelcomeMessage()
{
    string userName;
    Console.Write("Enter your name: ");
    userName = Console.ReadLine();
    if (userName == null)
    {
        Console.WriteLine("");
        Console.WriteLine("*************************");
        Console.WriteLine("Welcome to My Application");
        Console.WriteLine("*************************");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("**********************************");
        Console.WriteLine("Welcome {0}, to My Application!", userName);
        Console.WriteLine("**********************************");
    }
}
WelcomeMessage();*/

//EXERCISE 8B - COMPLEX INFO
void UserInformation()
{
    int myAge = 36;
    string myName = "Jacob";

    int userAge;
    string userName ="";

    Console.Write("Enter your age: ");
    while (true)
    {
        try
        {
            userAge = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid entry, please enter again.");
            Console.Write("Enter your age: ");
        }
    }
    while (userName.Length < 1)
    {
        Console.Write("Enter your name: ");
        userName = Console.ReadLine();
        if(userName.Length < 1)
        {
            Console.WriteLine("No name entered, try again!");
        }
    }
    if (myAge > userAge)
    {
        var ageDifference = myAge - userAge;
        Console.WriteLine("I am older than you. The age difference is {0} year(s)", ageDifference);
    }
    else if (myAge == userAge)
    {
        Console.WriteLine("We are the same age.");
    }
    else
    {
        var ageDifference = userAge - myAge;
        Console.WriteLine("You are older than me. The age difference is {0} year(s)", ageDifference);
    }
    if (myName.Length > userName.Length)
    {
        Console.WriteLine("My name is longer than yours.");
    }
    else if (myName.Length == userName.Length)
    {
        Console.WriteLine("Our names are the same length.");
    }
    else
    {
        Console.WriteLine("Your name is longer than mine.");
    }

}

UserInformation();