// See https://aka.ms/new-console-template for more information
using System;
public class Converter
{
    private static double kilometers, miles, celsius, fahrenheit, USDollars, PHPeso;
    public static double ConvertKilometersToMiles(double value)
    {
        kilometers = value;
        return kilometers * 0.621371;
    }
    public static double ConvertMilesToKilometers(double value)
    {
        miles = value;
        return miles * 1.60934;
    }
    public static double ConvertCelsiusToFahrenheit(double value)
    {
        celsius = value;
        return (celsius * 9 / 5) + 32;
    }
    public static double ConvertFahrenheitToCelsius(double value)
    {
        fahrenheit = value;
        return (fahrenheit - 32) * 5 / 9;
    }
    public static double ConvertUSDollarsToPHPesos(double value)
    {
        USDollars = value;
        return USDollars * 56.21;
    }
    public static double ConvertPHPesoToUSDollars(double value)
    {
        PHPeso = value;
        return PHPeso / 56.21;
    }
}


public class Driver
{
    public static void Main()
    {
        Converter converter = new Converter();
        bool running = true;
        while(running)
        {
            Console.WriteLine(@"
Press the number of which value you want to convert.
[1] Kilometers to Miles
[2] Miles to Kilometers
[3] Celcius to Fahrenheit
[4] Fahrenheit to Celcius
[5] US Dollar to PH Peso
[6] PH Peso to US Dollar
[7] Exit");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Console.WriteLine("Enter the value of Kilometers: ");
                    Console.WriteLine("The Value is: " + Converter.ConvertKilometersToMiles(double.Parse(Console.ReadLine())));
                    break;
                case "2":
                    Console.WriteLine("Enter the value of Miles: ");
                    Console.WriteLine("The Value is: " + Converter.ConvertMilesToKilometers(double.Parse(Console.ReadLine())));
                    break;
                case "3":
                    Console.WriteLine("Enter the value of Celsius: ");
                    Console.WriteLine("The Value is: " + Converter.ConvertCelsiusToFahrenheit(double.Parse(Console.ReadLine())));
                    break;
                case "4":
                    Console.WriteLine("Enter the value of Fahrenheit: ");
                    Console.WriteLine("The Value is: " + Converter.ConvertFahrenheitToCelsius(double.Parse(Console.ReadLine())));
                    break;
                case "5":
                    Console.WriteLine("Enter the value of US Dollar: ");
                    Console.WriteLine("The Value is: " + Converter.ConvertUSDollarsToPHPesos(double.Parse(Console.ReadLine())));
                    break;
                case "6":
                    Console.WriteLine("Enter the value of Peso: ");
                    Console.WriteLine("The Value is: " + Converter.ConvertPHPesoToUSDollars(double.Parse(Console.ReadLine())));
                    break;
                case "7":
                    running = false;
                    break;
            }
        }
    }
}
