

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

Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

//-----------------------Exercise-2-----------------------------------

//Area of a circle calculations

Console.WriteLine("What is the radius of your cirlce?");
var userInput = Console.ReadLine();
var raduis = double.Parse(userInput);
Console.WriteLine($"The area of a circle with the raduis of {userInput} is:");
Console.WriteLine(AreaOfCircle(raduis));

 

 static double AreaOfCircle(double radius)
{
    var area = Math.PI * Math.Pow(radius, 2);
    return area;

}

