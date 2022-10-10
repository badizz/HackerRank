﻿using System;

public class camelCase
{
    // first solution
    public static int camelcase(string s)
    {
        int res = 1;
        char[] myArr = s.ToArray();
        foreach (char c in myArr){
            if (Char.IsUpper(c))
                res++;
        }
        return res;
    }

    //solution 2
    public static int camelcase(string s)
    {
        int res = 1;
        for (int k = 0; k < s.Length; k++){
            if (s[k] >= 'A' && s[k] <= 'Z'){
                res++;
            }
        }
        return res;
    }
}
