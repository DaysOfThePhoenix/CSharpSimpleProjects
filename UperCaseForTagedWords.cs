using System;
using System.Collections.Generic;
using System.Text;

class Uppercase
{
    static void Main()
    {
        int startIndexOpening = 0;
        int startIndexClosing = 0;
        List<int> openingTags = new List<int>();
        List<int> closingTags = new List<int>();
        List<StringBuilder> lower = new List<StringBuilder>();
        string someText = "We are <upcase>living</upcase> in a <upcase>yellow submarine</upcase>. We <upcase>don't</upcase> have <upcase>anything</upcase> else.";
        while (someText.IndexOf("<upcase>",startIndexOpening) != -1)
        {
            int index = someText.IndexOf("<upcase>",startIndexOpening);
            openingTags.Add(index);
            startIndexOpening = index+1;
        }
        while (someText.IndexOf("</upcase>", startIndexClosing) != -1)
        {
            int index = someText.IndexOf("</upcase>", startIndexClosing);
            closingTags.Add(index);
            startIndexClosing = index + 1; 
        }
        StringBuilder result = new StringBuilder(someText);
        for (int i = 0; i < openingTags.Count; i++ )
        {
            for (int j = openingTags[i] + 8; j < closingTags[i]; j++)
            {
                if (Char.IsLetter(result[j]))
                {

                    result[j] = Char.ToUpper(result[j]);
                }
            }
        }
        result.Replace("<upcase>","");
        result.Replace("</upcase>", "");
        string res = result.ToString();
        Console.WriteLine(res);
    }
}
