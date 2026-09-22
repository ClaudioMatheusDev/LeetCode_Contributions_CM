public class Program
{
    public static void Main(string[] args)
    {
        var p = new Program();
        System.Console.WriteLine(p.IsPalindrome(121));
    }

    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        int original = x;
        long invertido = 0;

        while (x > 0)
        {
            int ultimoDigito = x % 10;

            invertido = invertido * 10 + ultimoDigito;

            x = x / 10;
        }

        return original == invertido;
    }
}
