using System;
using System.Text;
using System.Text.RegularExpressions;

class TitleAndBody
{
    static void Main()
    {
        string html = @"<html>
  <head><title>News</title></head>
  <body><p><a href=""http://academy.telerik.com"">Telerik Academy</a> aims to provide free real-world practical training for young 
people who want to turn into skillful .NET software engineers.</p></body></html>";
        foreach (object titleTaged in Regex.Matches(html, @"<title>(.*?)</title>"))
        {
            string title = titleTaged.ToString();
            int indexTitleStart = title.IndexOf(">")+1;
            int indexTitleEnd = title.IndexOf("</", indexTitleStart);
            StringBuilder titleSB = new StringBuilder();
            for (int i = indexTitleStart ; i < indexTitleEnd ; i++)
            {
                titleSB.Append(title[i]);
            }
            Console.WriteLine("title: {0}", titleSB );
        }

        int indexBodyStart = html.IndexOf("<body>") + 6;
        int indexBodyEnd = html.IndexOf("</body>", indexBodyStart);
        StringBuilder bodySB = new StringBuilder();

        for (int i = indexBodyStart; i < indexBodyEnd; i++)
        {
            bodySB.Append(html[i]);
        }
        foreach (object tag in Regex.Matches(bodySB.ToString(),@"<(.*?)>"))
        {
            int index = bodySB.ToString().IndexOf(tag.ToString());
            bodySB.Remove(index,tag.ToString().Length);
        }
        Console.WriteLine("body: \n{0}", bodySB);
    }
}
