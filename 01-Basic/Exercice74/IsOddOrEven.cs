namespace Exercice74
{
    public class IsOddOrEven
    {
        public static string LengthOddOrEven(string str)
        {
            if (str.Length % 2 == 0)
            {
                return "Comprimento Par";
            }
            else
            {
                return "Comprimento Impar";
            }
        }
    }
}