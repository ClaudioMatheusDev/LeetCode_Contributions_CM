using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var p = new Program();
        int[] resultado = p.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

        System.Console.WriteLine(string.Join(", ", resultado));
    }
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> mapa = new Dictionary<int, int>();

        int complemento = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            complemento = target - nums[i];
            
            if (mapa.ContainsKey(complemento))
            {
                return new int[] { mapa[complemento], i };
            }

            if (!mapa.ContainsKey(nums[i]))
            {
                mapa.Add(nums[i], i);
            }
        }

        return new int[] { };
    }

}