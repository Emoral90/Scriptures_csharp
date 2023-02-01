using System;
using System.IO;

public class File
{
    public void read_from_file()
    {
        try
        {
            // Open the text file using a stream reader.
            using (var sr = new StreamReader("scriptures.txt"))
            {
                // Read the stream as a string, and write the string to the console.
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}