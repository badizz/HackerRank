using System.IO;
using System.Linq;
using System.Text;
using System;

class migratoryBirds
{

    /*  
     * Constraints
     *  It is guaranteed that each type is 1,2,3,4,5.
     *  5 <= n <= 2* (10^5)
     */
     
    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        for (int i = 1; i < 6; i++){
            myDict[i] = 0;
        }
        foreach (int tmp in arr){
            myDict[tmp]++;
        }
        int maxVal = myDict.Max(x => x.Value);
        var result = myDict.Where(x => x.Value == maxVal).OrderBy(x => x.Key).First();

        return result.Key;
    }


    // different solution 
    public static int migratoryBirds2(List<int> arr)
    {
        var indexGroups = (from c in arr
                           group c by c into g
                           select new
                           {
                               indx = g.Key,
                               count = g.Count(),
                           }).OrderByDescending(x => x.count).ThenBy(k => k.indx).First();

        return indexGroups.indx;
    }

}