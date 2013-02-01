//Solution for:
//You are given a text. Write a program that changes the text in all regions surrounded
//by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.
using System;
using System.Collections.Generic;
using System.Text;

class Uppercase
{
    static void Main()
    {
        int startIndexOpening = 0;
        int startIndexClosing = 0;
        List<int> openingTags = new List<int>(); //list that holds the starting indexes of all opening tags
        List<int> closingTags = new List<int>(); //list that holds the starting indexes of all closing tags
        
        string someText = "We <upcase>don't</upcase> have <upcase>anything</upcase> else.";
        while (someText.IndexOf("<upcase>",startIndexOpening) != -1)
        {
            int index = someText.IndexOf("<upcase>",startIndexOpening);
            openingTags.Add(index);
            startIndexOpening = index+1;
        } //fils the opening list with indexes unless there are none opening tags left
        
        while (someText.IndexOf("</upcase>", startIndexClosing) != -1)
        {
            int index = someText.IndexOf("</upcase>", startIndexClosing);
            closingTags.Add(index);
            startIndexClosing = index + 1; 
        } //fils the closing list with indexes unless there are none closing tags left
        
        StringBuilder result = new StringBuilder(someText);
        for (int i = 0; i < openingTags.Count; i++ )
        {
            for (int j = openingTags[i] + 8; j < closingTags[i]; j++)
            {
                if (Char.IsLetter(result[j]))
                {

                    result[j] = Char.ToUpper(result[j]); //ups the letters between the tags
                }
            }
        }
        result.Replace("<upcase>",""); //removes opening tags
        result.Replace("</upcase>", ""); //removes closing tags
        string res = result.ToString(); //convers the StringBulder into string
        Console.WriteLine(res);
    }
}
