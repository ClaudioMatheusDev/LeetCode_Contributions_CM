public class Program
{
    public static void Main(string[] args)
    {
        var p = new Program();
        int[] nums = { 3, 2, 2, 3 };
        System.Console.WriteLine(p.RemoveElement(nums, 3));
    }

    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {

                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}