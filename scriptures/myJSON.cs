using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

class myJSON
{
    //Attributes
    private string filePath = "NT.json";
    private string jsonScriptures;
    // Deserialize json into a dictionary
    private Dictionary<string, object> dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(file_path)

    // Methods
    public void getScriptures()
    {
        // // Read and display NT.json as a string
        // using (StreamReader sr = new StreamReader(filePath))
        // {
        //     jsonScriptures = sr.ReadToEnd();
        //     Console.WriteLine(jsonScriptures);
        // }

        string ref = dict["reference"].ToString();
        Console.WriteLine(ref);

    }
}