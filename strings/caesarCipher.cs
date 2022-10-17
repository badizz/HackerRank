using System;

public class caesarCipher
{
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
}
