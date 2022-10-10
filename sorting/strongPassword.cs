using System;

public class strongPassword
{
    public static int minimumNumber(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        string special_characters = "!@#$%^&*()-+";
        int requiredMinNum = 0;

        if (!password.Any(char.IsDigit))
            requiredMinNum++;

        if (!password.Any(char.IsLower))
            requiredMinNum++;

        if (!password.Any(char.IsUpper))
            requiredMinNum++;

        if (!password.Intersect(special_characters).Any())
            requiredMinNum++;

        return Math.Max(requiredMinNum, 6 - n);
    }

    //other solution
    public static int minimumNumber2(int n, string password)
    {
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";
        bool numFlag = false, lowerFlag = false, upperFlag = false, specialFlag = false;
        int minNumberCount = 0;

        foreach (char c in password){
            if (numbers.Contains(c))
                numFlag = true;
            if (lower_case.Contains(c))
                lowerFlag = true;
            if (upper_case.Contains(c))
                upperFlag = true;
            if (special_characters.Contains(c))
                specialFlag = true;
        }

        if (!numFlag)
            minNumberCount++;
        if (!lowerFlag)
            minNumberCount++;
        if (!upperFlag)
            minNumberCount++;
        if (!specialFlag)
            minNumberCount++;

        return (n > 6 || (6 - n < minNumberCount)) ? minNumberCount : 6 - n;
    }
}
