using System;
using System.IO;

// Class for only handling IO file functions
public class File
{
    // Attributes
    string file_path = "scriptures.txt";
    string scriptures_text;
    string scriptures_ref;

    public void read_from_file()
    {
        try
        {
            // Open the text file using a stream reader.
            using (var sr = new StreamReader(file_path))
            {
                // Read one line at a time and display it to the console
                while (!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split("|");
                    scriptures_text = lines[0];
                    scriptures_ref = lines[1];

                    // Display the first 20 words of each scripture
                    string[] words = scriptures_text.Split(" ");
                    for (int i = 0; i < 20; i++)
                    {
                        Console.WriteLine(words[i]);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file could not be read");
        }
    }

    public void write_to_file(string text)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(file_path, true))
            {
                for (int i=0; i<3; i++)
                {
                    sw.WriteLine(text);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file could cot be read");
        }
    }
}