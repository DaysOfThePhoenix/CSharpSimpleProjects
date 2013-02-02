//Solution for:
//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary.


using System;
using System.Text;

class Dictionary
{
    static void Main()
    {
        bool inDictionary = false; //checks if the input word exist in the dictionary data base
        string lines = ".NET \U+2014 platform for applications from Microsoft\nCLR \U+2014 managed execution environment for .NET\nnamespace \U+2014 hierarchical organization of classes";
        string[] dictionaryDataCenter = lines.Split('\n');
        string word = Console.ReadLine(); //reads word from the console for search in the dictionary
        for (int i = 0; i < dictionaryDataCenter.Length; i++)
        {
            string[] def = dictionaryDataCenter[i].Split('\U+2014');
            for (int j = 0; j < def.Length; j++) //trims the definitions and the defined words from spaces 
            {
                def[0] = def[0].Trim();
                def[1] = def[1].Trim();
            }
            if (string.Compare(def[0], word, true) == 0) //if there is match (case-insensitive) prints the definition on the console
            {
                Console.WriteLine("Definition for \"{0}\": {1}.",word, def[1]);
                inDictionary = true;
            }
        }
        if (inDictionary == false)
        {
            Console.WriteLine("No matches for {0}!", word);
        }
    }
}
