// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

//initializing string with default value
string name = String.Empty; //dynamic value
int age = 0;

Console.WriteLine("Please enter your Name and Age: ");
name = Console.ReadLine();
age= Convert.ToInt32(Console.ReadLine());

//static message with dynamic value
Console.WriteLine("I am " + name + " My age: "+age ); //string concatenation
Console.WriteLine($"They called me {name}"); //string interpolation
Console.WriteLine("I was given the name {0}", name); //formatted string

//Sample Calculator
int choice = 0, num1, num2, answer=0;
Console.WriteLine();

Console.WriteLine("Please select the operation:");
Console.WriteLine("1.Addition");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Division");

choice = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter first value");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second value");
num2 = Convert.ToInt32(Console.ReadLine());


switch (choice)
{
    case 1:
        answer= num1+num2;
        break;
    case 2:
        answer = num1 - num2;
        break;
    case 3:
        answer = num1 * num2;
        break;
    case 4:
        answer = num1/num2;
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;
}

Console.WriteLine($"The Answer is: {answer}");
