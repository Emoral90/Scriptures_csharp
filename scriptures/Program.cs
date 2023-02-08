﻿using System;
using System.IO;

public class Program
{
    // Attributes
    // static bool quit; 
    static void Main()
    {
        // Constructors
        File f = new File();

        string user_choice = "";

        // Console.WriteLine(user_choice);

        while (user_choice != "quit")
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("==========================");
            Console.WriteLine("1 Display all scriptures");
            Console.WriteLine("2 Display all references");
            Console.WriteLine("Type `quit` to end program");
            Console.WriteLine("==========================");

            user_choice = Console.ReadLine();
            
            if (user_choice == "1")
            {
                f.print_scrip();
            }

            if (user_choice == "2")
            {
                f.print_ref();
            }
        }
        
    }
}