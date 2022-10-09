using System;

public class betweenTwoSets
{

    //brute force
    public static int getTotalX(List<int> a, List<int> b)
    {
        int c = 0;
        for (int i = 1; i < 10000; i++)
        {
            if (a.Any(x => i % x != 0)) continue;
            if (b.Any(x => x % i != 0)) continue;
            c++;
        }
        return c;
    }

    //solution 1
    public static int getTotalX2(List<int> a, List<int> b)
    {
        int totalXs = 0, counter = 1;
        int maximumA = a.Max();
        int minBval = b.Min();
        int multipleOfMaxA = maximumA;

        while (multipleOfMaxA <= minBval)
        {
            bool factorOfAll = true;

            foreach (int item in a){
                if (multipleOfMaxA % item != 0){
                    factorOfAll = false;
                    break;
                }
            }

            if (factorOfAll){
                foreach (int item in b){
                    if (item % multipleOfMaxA != 0){
                        factorOfAll = false;
                        break;
                    }
                }
            }

            if (factorOfAll)
                totalXs++;

            counter++;
            multipleOfMaxA = maximumA * counter;
        }
        return totalXs;
    }

    
}
