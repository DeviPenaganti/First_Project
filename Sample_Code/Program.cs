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
Console.WriteLine("I am " + name + "My age: "+age ); //string concatenation
Console.WriteLine($"They called me {name}"); //string interpolation
Console.WriteLine("I was given the name {0}", name); //formatted string

