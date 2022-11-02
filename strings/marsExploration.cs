using System;

public class marsExploration
{
    //solution 1
    public static int marsExploration(string s)
    {
        int result = 0;
        int count = s.Length / 3;
        int indexO = 1;
        for (int i = 0; i < s.Length; i++){
            if (i == indexO){
                if (s[i] != 'O'){
                    result++;
                }
                indexO += 3;
            }
            else {
                if (s[i] != 'S')
                    result++;
            }
        }
        return result;
    }

    //solution 2
    public static int marsExploration2(string s)
    {
        int result = 0;
        string word = "SOS";
        for (int i = 0; i < s.Length; i++){
            if (s[i] != word[i % 3])
                result++;
        }
        return result;
    }
}
