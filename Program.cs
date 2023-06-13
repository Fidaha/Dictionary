namespace Dictionary;

class Program
{
    static void Main(string[] args)
    {


        Dictionary<char, string> letterDictionary = new Dictionary<char, string>();
        letterDictionary['a'] = "word1";
        letterDictionary['b'] = "word2";
        letterDictionary['c'] = "word3";

        foreach(KeyValuePair<char,string> kvp in letterDictionary)
        {
           // Console.WriteLine(kvp);
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            
        }

        Console.WriteLine("");
        letterDictionary.Remove('c');

        
        foreach(KeyValuePair<char,string> kvp in letterDictionary)
        {
           // Console.WriteLine(kvp);
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            
        }
    }
}
