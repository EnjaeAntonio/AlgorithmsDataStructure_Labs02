//Write and test the following methods in a Console Application. 
//A program that produces an array of all of the characters that appear more than once in a string.
//For example, the string “Programmatic Python” would result in the array ['p','r','o','a','m','t'].
//A program returns an array of strings that are unique words found in the argument.
//For example, the string “To be or not to be” returns ["to","be","or","not"].
//A program that reverses a provided string 
//A program that finds the longest unbroken word in a string and prints it
//For example, the string "Tiptoe through the tulips" would print "through"
//If there are multiple words tied for greatest length, print the last one

string input = "Programmatic Python";
char[] result = new char[input.Length];
int index = 0;
for (int i = 0; i < input.Length; i++)
{
    for (int j = i + 1; j < input.Length; j++)
    {
        Console.WriteLine(input[j]);
        if (input[i] == input[j] && !result.Contains(input[i]))
        {

            result[index] = input[i];
            index++;
        }
    }
}