//Solution for:
//Write a program that reads a list of words from a file words.txt and finds how many times 
//each of the words is contained in another file test.txt. 
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences
//in descending order. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class LetscCuntSomeWords
{
    static void Main()
    {
        try
        {
            string wordsStr = null; //string for the file, containing the words that are going to be counted later
            StreamReader words = new StreamReader(".../.../words.txt");
            using (words) //reading from the text files in which we are going to count the given words
            {
                wordsStr = words.ReadToEnd();
            }

            string[] oneWordOnly = wordsStr.Split('\n', ' '); //splitting string into sepatate words
            for (int i = 0; i < oneWordOnly.Length; i++)
            {
                oneWordOnly[i] = oneWordOnly[i].TrimEnd('\r'); //trimming the words for being exact
            }
            int[] counters = new int[oneWordOnly.Length]; //assigning counters for each word
            StreamReader text = new StreamReader(".../.../text.txt");
            using (text)
            {
                string line = text.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < counters.Length; i++)
                    {
                        counters[i] += Regex.Matches(line, @"\b" + oneWordOnly[i] + @"\b").Count; //counting the words
                    }
                    line = text.ReadLine();
                }
            }

            List<string> output = new List<string>();
            for (int i = 0; i < oneWordOnly.Length; i++)
            {
                oneWordOnly[i] = counters[i].ToString() + "times - " + oneWordOnly[i];
                output.Add(oneWordOnly[i]);
            }
            output.Sort();
            StreamWriter outputInFile = new StreamWriter(".../.../output.txt", false);
            using (outputInFile)
            {
                foreach (var item in output)
                {
                    outputInFile.WriteLine(item);
                }
            }
        }
        
        //handling exceptions
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }

        catch (DirectoryNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }

        catch (IOException fe)
        {
            Console.WriteLine(fe.Message);
        }

        catch (SecurityException fe)
        {
            Console.WriteLine(fe.Message);
        }

        catch (UnauthorizedAccessException fe)
        {
            Console.WriteLine(fe.Message);
        }
    }
}
