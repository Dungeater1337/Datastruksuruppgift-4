using System;

class Program
{

    static int AdderaTvåTal(int[] arr)
    {
        HashSet<int> numbers = new HashSet<int>();
        int target = -2;

        for (int i = 0; i < arr.Length; i++)
        {
            int comp = target - arr[i];

            if(numbers.Contains(comp))
            {
                return 1;
            }

            numbers.Add(arr[i]);
        }

        return 0; 
    }
    static void Main(string[] args)
    {
        int[] arr = new int[]{0, -1, 2, -3, 1};
        AdderaTvåTal(arr);
        if(AdderaTvåTal(arr) != 0)
        {
            Console.WriteLine("Tal hittades"); 
        }
        else
        {
            Console.WriteLine("Inga tal hittades");
        }
    }
}