
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        // FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"
        FindMinimum(45,15,50);
        FindMaximum(45,15,50);

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:

    public static void CheckForPositiveNegativeZero(int number)
    {
        if(number<0)
        {
            Console.WriteLine("Your number is negative.");
        }
        else if(number>0)
        {
            Console.WriteLine("You number is positive.");
        }
        else
        {
            Console.WriteLine("Your number is zero.");
        }
    }

    public static void FindMinimum(int x, int y, int z)
    {
        if(x < y && x < z)
        {
            Console.WriteLine("The minimum value is " + x + ".");
        }
        else if(y < x && z < x)
        {
            Console.WriteLine("The minimum value is " + y + ".");
        }
        else
        {
            Console.WriteLine("The minimum value is " + z + ".");
        }
    }

    public static void FindMaximum(int x, int y, int z)
    {
        if(x < y && x < z)
        {
            Console.WriteLine("The maximum value is " + x + ".");
        }
        else if(y < x && z < x)
        {
            Console.WriteLine("The maximum value is " + y + ".");
        }
        else
        {
            Console.WriteLine("The maximum value is " + z + ".");
        }
    }
    
    public static void IsDivisibleBy5(int number)
    {
        if(number % 5 == 0)
        {
            Console.WriteLine(number + " is divisible by 5.");
        }
        else
        {
            Console.WriteLine(number + " is not divisible by 5.");
        }
    }

    public static void CheckEvenOrOdd(int number)
    {
        if(number % 2 == 0)
        {
            Console.WriteLine(number + " is an even number.");
        }
        else
        {
            Console.WriteLine(number + " is an odd number."); 
        }
    }

    public static void CheckVowelOrConsonant(char letter)
    {
        if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y' 
        || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y')
        {
            Console.WriteLine(letter + " is a vowel.");
        }
        else
        {
            Console.WriteLine(letter + " is a consonant.");
        }
    }

    public static void DisplayDayOfWeek(int dayCode)
    {
        if(dayCode == 0)
        {
            Console.WriteLine(dayCode + " - Sunday.");
        }
        else if(dayCode == 1)
        {
            Console.WriteLine(dayCode + " - Monday.");
        }
        else if(dayCode == 2)
        {
            Console.WriteLine(dayCode + " - Tuesday.");
        }
        else if(dayCode == 3)
        {
            Console.WriteLine(dayCode + " - Wednesday.");
        }
        else if(dayCode == 4)
        {
            Console.WriteLine(dayCode + " - Thursday.");
        }
        else if(dayCode == 5)
        {
            Console.WriteLine(dayCode + " - Friday.");
        }
        else if(dayCode == 6)
        {
            Console.WriteLine(dayCode + " - Saturday.");
        }
        else
        {
            Console.WriteLine(dayCode + " - INVALID.");
        }
    }
}

