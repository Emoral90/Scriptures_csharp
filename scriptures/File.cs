using System;
using System.IO;

// Class for only handling IO file functions
public class File
{
    // Attributes
    string scriptures_text;
    string scriptures_ref;

    public void read_from_file()
    {
        try
        {
            // Open the text file using a stream reader.
            using (var sr = new StreamReader("scriptures.txt"))
            {

                // Read one line at a time and display it to the console
                while (!sr.EndOfStream){
                    string[] lines = sr.ReadLine().Split("|");
                    scriptures_text = lines[0];
                    scriptures_ref = lines[1];
                    Console.WriteLine(scriptures_text);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file could not be read:");
        }
    }
}