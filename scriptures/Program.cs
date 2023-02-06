using System;
using System.IO;

public class Program
{
    static string someText = "==Here is some text to be added after the original text==";
    static void Main()
    {
        // Constructors
        File f = new File();

        f.read_from_file();

        // f.write_to_file(someText);

        // Console.WriteLine($"This is the scripture text: {f.get_scrip_text()}");
        // Console.WriteLine("===================================================================================");
        // Console.WriteLine($"This is the scripture reference: {f.get_scrip_ref()}");
    }
}