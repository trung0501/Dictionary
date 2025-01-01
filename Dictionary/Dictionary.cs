using System;
using System.Collections.Generic;

public class Dictionary
{
    public static void Main()
    {
        IDictionary<int, string> numberNames = new Dictionary<int, string>();

        // Use the Add() method to add elements to the Dictionary 
        numberNames.Add(1, "One");
        numberNames.Add(3, "Three");
        numberNames.Add(2, "Two");

        // Use the foreach method to print elements to the screen
        foreach (KeyValuePair<int, string> kvp in numberNames)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine();

        //Declare and initialize key / value using initializers
        var cities = new Dictionary<string, string>() {
            {"Viet Nam","Ha Noi, Thanh pho Ho Chi Minh, Quang Ninh"},
            {"Russia"," Moscow,  Saint Petersburg, Volgograd"},
            {"Cuba","La Habana, Santiago de Cuba, Camaguey"}
        };

        // Use the foreach method to print elements to the screen
        foreach (var kvp in cities)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine("----------------------------------------");
    }
}