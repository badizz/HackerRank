using System;

public class pangrams
{
    public static string pangrams(string s)
    {
        int uniqLetterCount = s.ToLower().Distinct().ToArray().Count();
        return (uniqLetterCount == 27) ? "pangram" : "not pangram";
    }

    //  https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-6.0
    public static string pangrams2(string s)
    {
        HashSet<char> hashSet = new HashSet<char>(s.ToLower().ToCharArray());
        return (hashSet.Contains(' ') && hashSet.Count == 27) ? "pangram" : "not pangram";
    }
}
