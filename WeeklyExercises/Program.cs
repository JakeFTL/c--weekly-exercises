/*EXERCISE 1
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

//EXERCISE 2
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
}