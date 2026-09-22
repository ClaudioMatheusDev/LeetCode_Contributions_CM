public class Program
{
    public static void Main(string[] args)
    {
        var p = new Program();
        System.Console.WriteLine(p.RemoveDuplicates(new int[] { 1, 1, 2 }));
    }
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[k - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }

}