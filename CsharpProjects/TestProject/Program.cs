/*
 * This program reverses a string and counts the occurrences of the letter 'o'.
 * It demonstrates basic string manipulation in C#.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = originalMessage.ToCharArray();

Array.Reverse(charMessage);
int charCount = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        charCount++;
    }
}

// convert it back to a string
string newMessage = new String(charMessage);

// print it out
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {charCount} times.");