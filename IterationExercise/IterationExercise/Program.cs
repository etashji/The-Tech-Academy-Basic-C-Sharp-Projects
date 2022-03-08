using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] verbs = { "Find", "Lick", "Eat", "Drink" };
        Console.WriteLine("What three letters do you add to the end of a verb to change it from simple present tense to progressive tense?");
        string ending = Console.ReadLine();
        bool boolean = true;


        for (int j = 0; j < verbs.Length; j++)
        {
            verbs[j] = verbs[j] + ending;
            Console.WriteLine(verbs[j]);

        } while (boolean)
        {
            Console.WriteLine("To infinity and beyond!");
            boolean = false;
        } for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Less than Loop");
        } for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Less than or equal to loop");
        }

        List<string> cars = new List<string>() { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine("What is your favorite brand of car?");
        string response = Console.ReadLine();
        bool indexBool = false;

        foreach (string car in cars)
        { 
            if (car == response)
            {
                int index = cars.IndexOf(car);
                do
                {
                    switch (index)
                    {
                        case 0:
                            Console.WriteLine("Your car is located at index: " + index);
                            indexBool = true;
                            break;
                        case 1:
                            Console.WriteLine("Your car is located at index: " + index);
                            indexBool = true;
                            break;
                        case 2:
                            Console.WriteLine("Your car is located at index: " + index);
                            indexBool = true;
                            break;
                        case 3:
                            Console.WriteLine("Your car is located at index: " + index);
                            indexBool = true;
                            break;
                        default:
                            Console.WriteLine("Your car is not on the list.");
                            break;
                    }
                } while (!indexBool);
            } 
        } Console.ReadLine();
    } 
}
