using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] verbs = { "Find", "Lick", "Eat", "Drink" }; //This establishes the verbs array
        Console.WriteLine("What three letters do you add to the end of a verb to change it from simple present tense to progressive tense?"); //This asks the user a question
        string ending = Console.ReadLine(); //This turns the user input into the ending string
        bool boolean = true; //This establishes the boolean


        for (int j = 0; j < verbs.Length; j++) //This iterates through the verbs array
        {
            verbs[j] = verbs[j] + ending; //This concatenates strings in the array with the user's input.
            Console.WriteLine(verbs[j]); //This displays the new entries in the array

        } while (boolean) //This establishes the while loop that is infinite
        {
            Console.WriteLine("To infinity and beyond!"); //This prints "To infinity and beyond!"
            boolean = false; //This changes the boolean to take us out of the while loop.
        }
        for (int i = 0; i < 10; i++) //This iterates using the int i and establishes that the loop is to continue as long as i is less than 10.
        {
            Console.WriteLine("Less than Loop"); //This writes "Less than Loop every time we go through the loop."
        }
        for (int i = 0; i <= 10; i++) //This iterates using the int i and establishes that the loop is to continue as lont as i is less than or equal to 10.
        {
            Console.WriteLine("Less than or equal to loop"); //This writes "Less than or equal to loop" every time we go thorugh the loop.
        }

        List<string> cars = new List<string>() { "Volvo", "BMW", "Ford", "Mazda" }; //This establishes the cars list.
        Console.WriteLine("What is your favorite brand of car?"); //This asks the user for their favorite type of car.
        int index = cars.IndexOf(Console.ReadLine()); //This changes the user's input to the "cars" integer.
        bool boolIndex = false; //This establishes the boolIndex boolean as false.
        do //This begins our "do" loop.
        {
            switch (index) //This establishes our switch statement using "index."
            {
                case 0: //This tells the computer what to do when index = 0
                    Console.WriteLine("Your favorite car is at index: " + index); //This tells the computer to print the given index.
                    boolIndex = true; //This makes the boolIndex boolean true.
                    break; //This tells the console to break the loop.
                case 1: //This tells the computer what to do when index = 1
                    Console.WriteLine("Your favorite car is at index: " + index); //This tells the computer to print the given index.
                    boolIndex = true; //This makes the boolIndex boolean true.
                    break; //This tells the console to break the loop.
                case 2: //This tells the computer what to do when index = 2
                    Console.WriteLine("Your favorite car is at index: " + index); //This tells the computer to print the given index.
                    boolIndex = true; //This makes the boolIndex boolean true.
                    break; //This tells the console to break the loop.
                case 3: //This tells the computer what to do when index = 3
                    Console.WriteLine("Your favorite car is at index: " + index); //This tells the computer to print the given index.
                    boolIndex = true; //This makes the boolIndex boolean true.
                    break; //This tells the console to break the loop.
                default: //This tells the computer what to do when index does not equal one of the indexes in the list.
                    Console.WriteLine("That car is not in the index."); //This tells the user their car is not in the index.
                    Console.WriteLine("What is your favorite brand of car?"); //This asks the user again for their favorite brand of car.
                    index = cars.IndexOf(Console.ReadLine()); //This converts the index integer into their new input.
                    break; //This tells the console to break the loop.
            }
        } while (!boolIndex); //This tells the loop to continue while boolIndex is not true.

        List<string> cars2 = new List<string>() { "Volvo", "Volvo", "BMW", "Ford", "Mazda" }; //This establishes the cars2 list.
        Console.WriteLine("What is your favorite type of car?"); //This asks the user for their favorite type of car.
        string response = Console.ReadLine(); //This saves the user's input.
        bool checker = false; //This establishes the checker boolean as false.

        for (int i = 0; i < cars2.Count; i++) //This establishes the for loop and tells it to iterate through the list.
        {
            if (cars2[i] == response) //This establishes the if statement for if the entry is equal to the response
            {
                Console.WriteLine("Your car is located at index: " + i); //This tells the checker to write out the index.
                checker = true; //This changes the checker to true.
            }
        }
        if (checker == false) //This tells the console what to do if the checker is false.
        {
            Console.WriteLine("Your car is not on the list."); //This tells the user their car is not on the list.
        }

        List<string> cars3 = new List<string>() { "Volvo", "Volvo", "BMW", "Ford", "Mazda" }; //This establishes the cars3 list
        List<string> empty = new List<string>(); //This establishes an empty list to determine if something is repeated.

        foreach (string car in cars3) //This establishes a foreach statement for the car string
        {
            bool checker2 = false; //This changes checker2 to false.
            foreach (string duplicate in empty) //This establishes another foreach loop for the empty list.
            {
                if (duplicate == car) //This is an if statement for if duplicate is equal to car.
                {
                    Console.WriteLine(car + " has already appeared in the list."); //This tells the console to write that their input has already appeared on the lsit.
                    checker2 = true; //This changes the checker2 to true
                }
            }
            if (checker2 == false) //This says what to do if checker2 is false.
            {
                Console.WriteLine(car); //This tells the console to just write the car variable.
                empty.Add(car); //This adds the car to the empty list as a duplicate to check for duplicates.
            }
        }
       Console.ReadLine(); //This ensures the console stays open.
    } 
}
