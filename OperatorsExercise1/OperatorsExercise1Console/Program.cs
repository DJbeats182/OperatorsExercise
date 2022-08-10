using System;
using OperatorsExercise1Console;

//-----------------------Exercise-1-----------------------------------

// Results of Addition, Subraction, Multiplication, Division, and Modulus

//Division

int a = 17;
int b =4;
double quotient = a / b;
double remainder = a % b;
int sum = a + b;
int difference = a - b;
int product = a * b;


if (a == 17 && b == 4)
{
    Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
}

//-----------------------Exercise-2-----------------------------------

//Area of a circle calculations

Console.WriteLine("What is the radius of your cirlce?");
var userInput = Console.ReadLine();
var raduis = double.Parse(userInput);
var answer = Methods.AreaOfCircle(raduis);
Console.WriteLine($"The area of a circle with the raduis of {userInput} is {answer}");


 

 

