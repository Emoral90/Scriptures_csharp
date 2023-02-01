using System;
using System.IO;

namespace ReadFromFile{
    class File{
        public void read_from_file(string[] args){
            string file_path = "scriptures.txt";

            try{
                // Read the contents of the txt file to a string
                string contents = File.ReadAllText(file_path);
                Console.WriteLine(contents);
            }
            // Print error message if specified file is not found
            catch(FileNotFoundException){
                Console.WriteLine($"Sorry the file {file_path} could not be found");
            }
            
        }
    }
}

// namespace WriteToFile{
//     public void write to file
// }