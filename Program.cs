//Write and test the following methods in a Console Application. 
//A program that produces an array of all of the characters that appear more than once in a string.
//For example, the string “Programmatic Python” would result in the array ['p','r','o','a','m','t'].

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
List<string> uniqueWords = new List<string>();

for (int i = 0; i < uniqueSentSplit.Length; i++)
{
    if (!uniqueWords.Contains(uniqueSentSplit[i]))
    {
        uniqueWords.Add(uniqueSentSplit[i]);
    }
}

foreach(string s in uniqueWords)
{
    Console.WriteLine(s);
}
 
//A program that reverses a provided string 

Console.WriteLine("Please enter a word to check if it is a palindrome");
string userPalin = Console.ReadLine();
char[] charArray = userPalin.ToCharArray();
string joinedWords = String.Join("", charArray).ToLower();
Array.Reverse(charArray);
string reversedWord = new string(charArray);
for (int j = 0; j < 1; j++)
{
    while (userPalin.Length < 3 || userPalin.IndexOf(" ") != -1)
    {
        Console.WriteLine("Please enter one word that is more than 3 letters and has no spaces  ");
        userPalin = Console.ReadLine();
    }

    if (joinedWords == reversedWord)
    {
        Console.WriteLine($"Your word reversed is '{reversedWord}' and is also a palindrome");
    }
    else
    {
        Console.WriteLine($"Your word reversed is '{reversedWord}' and is not a palindrome");
    }
}

//A program that finds the longest unbroken word in a string and prints it
//For example, the string "Tiptoe through the tulips" would print "through"

string sentence = "Tiptoe through subways the tulips";
string[] sentSplit = sentence.Split(' ');
string longestWord = "";
foreach(string word in sentSplit)
{
    if(word.Length > longestWord.Length)
    {
        longestWord = word;
    }
}
Console.WriteLine();    
Console.WriteLine($"The longest word is '{longestWord}'");