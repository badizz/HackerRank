using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class numberLineJumps
{

    // solution 1
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if ((x2 > x1 && v2 > v1) || (x1 > x2 && v1 > v2))
            return "NO";
        else{
            bool flag = false;
            int jump = 1;
            while (jump <= 10000){
                x1 += v1;
                x2 += v2;
                if (x1 == x2){
                    Console.WriteLine(jump);
                    flag = true;
                    return "YES";
                }
                jump++;
            }
            return "NO";
        }
    }



    // solution 2
    public static string kangaroo2(int x1, int v1, int x2, int v2)
    {
        if (x1 < x2 && v1 < v2)
            return "NO";

        else{
            if (v1 != v2 && ((x2 - x1) % (v2 - v1)) == 0)
                return "YES";
            else
                return "NO";
        }

    }

    // solution 3
    public static string kangaroo3(int x1, int v1, int x2, int v2)
    {
        return (v2 < v1) && ((x2 - x1) % (v1 - v2)) == 0 ? "YES" : "NO";
    }

}