class SubStrings
{
    public static void MySubString()
    {
        string name = "Spongebob Squarepants";

        string sponge = name.Substring(6,3);
        string pat = name.Replace("Spongebob","Patrick");
        
        Console.WriteLine(name);
        Console.WriteLine(sponge);
    }
}