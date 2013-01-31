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
            string wordsStr = null; //ще записва списъка с думите като стринг от начало до край
            StreamReader words = new StreamReader(".../.../words.txt");
            using (words) //четем списък с думи, които ще броим
            {
                wordsStr = words.ReadToEnd();
            }

            string[] oneWordOnly = wordsStr.Split('\n', ' '); //разделяме прочетените думи като стринг на отделни елементи
            for (int i = 0; i < oneWordOnly.Length; i++)
            {
                oneWordOnly[i] = oneWordOnly[i].TrimEnd('\r'); //изглаждаме ги от към краища 
            }
            int[] counters = new int[oneWordOnly.Length]; //създаваме им броячи, които ще се пазят в масив с индекси тези от масива на думите

            StreamReader text = new StreamReader(".../.../text.txt");
            using (text)
            {
                string line = text.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < counters.Length; i++)
                    {
                        counters[i] += Regex.Matches(line, @"\b" + oneWordOnly[i] + @"\b").Count; //за всяка дума от масива с думи прибавяме по колко пъти се среща на всеки ред от четения файл
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
