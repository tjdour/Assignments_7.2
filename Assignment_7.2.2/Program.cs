//Assignment 7.2.2
//Given a string s, reverse only all the vowels in the string and return it.

string vowels = "aeiou";

string s = "hello";
Console.WriteLine(ReverseVowels(s));

s = "avacado";
Console.WriteLine(ReverseVowels(s));

s = "intelligent";
Console.WriteLine(ReverseVowels(s));


string ReverseVowels(string s)
{
    char[] letters = s.ToCharArray();

    int left = 0;
    int right = letters.Length - 1;

    while (left < right)
    {
        while (left < right && !IsVowel(letters[left]))
        {
            left++;
        }

        while (left < right && !IsVowel(letters[right]))
        {
            right--;
        }

        char temp = letters[left];
        letters[left] = letters[right];
        letters[right] = temp;

        left++;
        right--;
    }

    return new string(letters);
}


bool IsVowel(char letter)
{
    letter = char.ToLower(letter);

    for (int i = 0; i < vowels.Length; i++)
    {
        if (letter == vowels[i])
        {
            return true;
        }
    }

    return false;
}