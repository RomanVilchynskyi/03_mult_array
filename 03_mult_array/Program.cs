internal class Program
{
    static void Print(int[,] arr)
    {
        /*for (int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j], -10}");
            }
            Console.WriteLine();
        }*/
        foreach (var item in arr)
        {
            Console.Write($"{item, -10}");
        }
        Console.WriteLine();
    }
    static void Print(int[][] arr)
    {
       /* for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr[i].Length;j++)
            {
                Console.Write($"{arr[i][j],-10}");
            }
            Console.WriteLine();
        }*/
       foreach(int[] row in arr)
       {
           foreach(var item in row)
           {
                Console.Write($"{item, -10}");
           }
           Console.WriteLine();
       }
    }
    static void MathRows(int[][] arr)
    {
        foreach (int[] row in arr)
        {
            Console.WriteLine($"Sum :: {row.Sum()}");
            Console.WriteLine($"Min :: {row.Min()}");
            Console.WriteLine($"Max :: {row.Max()}");
            Console.WriteLine($"Average :: {row.Average()}");
            Console.WriteLine();
        }
    }
    static void SwapRows(int[][] arr, int row1, int row2) 
    {
        if(row1 > 0 && row2 > 0 && row1 < arr.Length && row2 < arr.Length)
        {
            int[] tmp = arr[row1];
            arr[row1] = arr[row2];
            arr[row2] = tmp;
        }
    }
    private static void Main(string[] args)
    {
        /*int[,] arr = new int[3, 4] 
        {
        {1,5,3,6 },
        {2,2,5,4 },
        {2,3,9,5 } 
        };

        Console.WriteLine("Arr length:" + arr.Length);
        Console.Write("Arr length: " + arr);
        Print(arr);
        arr[0, 0] = 3;
        Print(arr);*/
        int[][] arr1 = new int[4][];
        arr1[0] = new int[] {1,256,3 };
        arr1[1] = new int[] {1,20,3,41,565 };
        arr1[2] = new [] {1,21 };
        arr1[3] = new [] {1,45,3,35 };
        Print(arr1);
        MathRows(arr1);
        for(int i = 0; i < arr1.Length / 2; i++)
        {
            SwapRows(arr1, i, arr1.Length - 1 - i);
        }
        Console.WriteLine();

        Print(arr1);
        //kjlkjlkjlkjlkjlkjlkj
    }
}