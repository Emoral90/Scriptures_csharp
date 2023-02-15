using System.IO;
class JSON
{
    //Attributes
    private string filePath = "NT.json";

    // Methods
    public void getScriptures()
    {
        var jsonStr = File.ReadAllText(filePath);
        var jsonObj = JObject.Parse(jsonStr);

        Console.WriteLine(jsonObj);
    }
}