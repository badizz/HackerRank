using System;

public class marsExploration
{
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
}
