namespace Exercice94;

public class Prefix
{
    public static string FindLongestCommonPrefix(string[] strings)
    {
        if (strings == null || strings.Length == 0)
        {
            return "";
        }

        string prefix = strings[0];

        for (int i = 1; i < strings.Length; i++)
        {
            while (!strings[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix.Length == 0)
                {
                    return "";
                }
            }
        }

        return prefix;
    }
}
