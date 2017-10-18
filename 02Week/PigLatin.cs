using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What's the word?");
        string word = Console.ReadLine();
        Console.WriteLine(translateWord(word));
        Console.ReadLine();
    }
    
    public static string translateWord(string word)
    {
        // SPEC 1
        /*
        //get first character of word using substring
        string firstLetter = word.Substring(0, 1);

        // also get rest of the word after first character
        string restOfWord = word.Substring(1);

        //combine the sub strings with "ay"
        return "Your word in Pig Latin is: " + restOfWord + firstLetter + "ay";
        */

        //SPEC 2 & 3

        //Find Index of First Vowel
        int indexOfFirstVowel = -1;

        if ((word.IndexOf('a') > -1 && word.IndexOf('a') > -indexOfFirstVowel)
            || indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('a');
        }
        if ((word.IndexOf('e') > -1 && word.IndexOf('e') > -indexOfFirstVowel)
            || indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('e');
        }
        if ((word.IndexOf('i') > -1 && word.IndexOf('i') > -indexOfFirstVowel)
            || indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('i');
        }
        if ((word.IndexOf('o') > -1 && word.IndexOf('o') > -indexOfFirstVowel)
           || indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('o');
        }
        if ((word.IndexOf('u') > -1 && word.IndexOf('u') > -indexOfFirstVowel)
            || indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('u');
        }
        if ((word.IndexOf('y') > -1 && word.IndexOf('y') > -indexOfFirstVowel)
            || indexOfFirstVowel == -1)
        {
            indexOfFirstVowel = word.IndexOf('y');
        }

        // break the word using first vowel index
        string ComplexWordBreak = word.Substring(indexOfFirstVowel);
        string FirstPart = word.Substring(0, indexOfFirstVowel);

        if (indexOfFirstVowel == 0)
        {
            return word + "yay";
        }
        else
        {
            return ComplexWordBreak + FirstPart + "ay";
        }



    }
}
