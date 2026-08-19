//Assignment 7.2.3
//Given two strings s and t, return true if t is an anagram of s, and false otherwise.
//An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
//typically using all the original letters exactly once.

string s = "anagram";
string t = "nagaram";

Console.WriteLine(IsAnagram(s, t));

s = "rat";
t = "car";

Console.WriteLine(IsAnagram(s, t));


bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }

    Dictionary<char, int> letterCounts = new Dictionary<char, int>();

    
    for (int i = 0; i < s.Length; i++)
    {
        if (letterCounts.ContainsKey(s[i]))
        {
            letterCounts[s[i]]++;
        }
        else
        {
            letterCounts[s[i]] = 1;
        }
    }

   
    for (int i = 0; i < t.Length; i++)
    {
        if (!letterCounts.ContainsKey(t[i]))
        {
            return false;
        }

        letterCounts[t[i]]--;

        if (letterCounts[t[i]] < 0)
        {
            return false;
        }
    }

    return true;
}