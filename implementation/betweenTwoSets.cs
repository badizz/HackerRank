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



    // gcd - lcm solution
    // greatest common divisor - obeb
    public static int getGCD(int n1, int n2)
    {
        if (n2 == 0){
            return n1;
        }
        return getGCD(n2, (n1 % n2));
    }

    // least common multiple - ekok
    public static int getLCM(int n1, int n2)
    {
        if (n1 == 0 || n2 == 0)
            return 0;
        else{
            int gcd = getGCD(n1, n2);
            return (Math.Abs(n1 * n2)) / gcd;
        }
    }

    public static int getTotalX3(List<int> a, List<int> b)
    {
        int result = 0;

        int lcm = a[0];
        foreach (int k in a){
            lcm = getLCM(lcm, k);
        }

        int gcd = b[0];
        foreach (int k in b){
            gcd = getGCD(gcd, k);
        }

        int multiple = 0;
        while (multiple <= gcd){
            multiple += lcm;
            if (gcd % multiple == 0)
                result++;
        }

        return result;
    }
}
