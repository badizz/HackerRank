using System;

public class caesarCipher
{
    //solution 1
    public static string caesarCipher(string s, int k)
    {
        char[] upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] lowerAlphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        StringBuilder result = new StringBuilder();

        foreach (char c in s)
        {
            int letterIndex = 0;
            int tmp = 0;
            if (!char.IsLetter(c)){
                result.Append(c);
            }
            else {
                if (Char.IsUpper(c)){
                    letterIndex = Array.IndexOf(upperAlphabet, c);
                    tmp = (letterIndex + k) % 26;
                    result.Append(upperAlphabet[tmp]);
                }
                else{
                    letterIndex = Array.IndexOf(lowerAlphabet, c);
                    tmp = (letterIndex + k) % 26;
                    result.Append(lowerAlphabet[tmp]);
                }
            }
        }
        return result.ToString();
    }



    //other way
    public static string caesarCipher2(string s, int k)
    {
        StringBuilder result = new StringBuilder();
        foreach (var c in s)
        {
            if (!char.IsLetter(c)){
                result.Append(c);
            }
            else{
                char startedCharacter = (char.IsUpper(c) == true) ? 'A' : 'a';
                int index = (c + k - startedCharacter) % 26;
                result.Append(Convert.ToChar(index + startedCharacter));
            }
        }
        return result.ToString();
    }
}
