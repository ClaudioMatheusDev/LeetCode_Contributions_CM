using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var p = new Program();
        int resultado = p.RomanToInt("IX");

        System.Console.WriteLine(resultado);
    }
    public int RomanToInt(string s)
    {
        Dictionary<char, int> mapa = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        int total = 0;


        for (int i = 0; i < s.Length; i++)
        {
            int atual = mapa[s[i]];

            if (i + 1 < s.Length)
            {
                int proximo = mapa[s[i + 1]];

                if (atual < proximo)
                {
                    total -= atual;
                }
                else
                {
                    total += atual;
                }
            }
            else
            {
                total += atual;
            }
        }

        return total;
    }
}

