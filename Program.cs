﻿//Write and test the following methods in a Console Application. 
//A program that produces an array of all of the characters that appear more than once in a string.
//For example, the string “Programmatic Python” would result in the array ['p','r','o','a','m','t'].


//A program that finds the longest unbroken word in a string and prints it
//For example, the string "Tiptoe through the tulips" would print "through"

string input = "Programmatic Python";
char[] result = new char[input.Length];
for (int i = 0; i < input.Length; i++)
{
    for (int j = i + 1; j < input.Length; j++)
    {
        if (input[i] == input[j] && !result.Contains(input[i]))
        {
            result[j] = input[i];   
        }
    }
}
Console.WriteLine(result);

//A program returns an array of strings that are unique words found in the argument.
//For example, the string “To be or not to be” returns ["to","be","or","not"].

string uniqueSentence = "To be or not to be";
string[] uniqueSentSplit = uniqueSentence.Split(' ');

for(int i = 0; i < uniqueSentSplit.Length; i++)
{
    for(int j = 0; j < uniqueSentSplit.Length; j++)
    {
        if (uniqueSentSplit[i] == uniqueSentSplit[j])
        {
            uniqueSentence = uniqueSentSplit[j];
            Console.WriteLine(uniqueSentSplit[j]);
        }
    }
}

//A program that reverses a provided string 

Console.WriteLine("Please enter a word to check if it is a palindrome");
string userPalin = Console.ReadLine();
char[] charArray = userPalin.ToCharArray();
string joinedWords = String.Join("", charArray).ToLower();
Array.Reverse(charArray);
