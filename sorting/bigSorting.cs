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

class bigSorting
{
    // TODO : review again

    // Could any sorting algorithm be implemented? 
    public static List<string> bigSorting(List<string> unsorted)
    {
        return unsorted.OrderBy(s => s.Length).ThenBy(s => s).ToList();
    }

}