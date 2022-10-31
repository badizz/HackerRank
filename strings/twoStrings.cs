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
}
