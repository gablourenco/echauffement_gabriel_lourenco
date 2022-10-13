Console.WriteLine("Bonjour")

public static bool IsPalindrome(string value)
{
    char[] forwards = (from c in value.ToLower().ToCharArray() where char.IsLetter(c) select c).ToArray();
    int middle = (forwards.Length / 2) + 1;
    for (int i = 0; i < middle; i++)
        if (forwards[i] != forwards[forwards.Length - 1 - i])
            return false;
    return true;
}