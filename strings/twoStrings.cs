using System;

public class twoStrings
{
    public static string twoStrings(string s1, string s2)
    {
        // convert string to Array. Then find intersect
        int intersectCount = s1.ToArray().Intersect(s2.ToArray()).Count();
        if (intersectCount > 0)
            return "YES";
        else
            return "NO";
    }

    // solution 2
    public static string twoStrings2(string s1, string s2)
    {
        char[] s1Arr = s1.ToCharArray();
        return (s2.IndexOfAny(s1Arr) != -1) ? "YES" : "NO";
    }

    // the other way
    public static string twoStrings(string s1, string s2)
    {
        HashSet<char> characterSet = new HashSet<char>();
        foreach (char c in s1){
            characterSet.Add(c);
        }
        foreach (char cx in s2){
            if (characterSet.Contains(cx))
                return "YES";
        }
        return "NO";
    }

}
