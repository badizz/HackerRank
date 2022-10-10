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
}
