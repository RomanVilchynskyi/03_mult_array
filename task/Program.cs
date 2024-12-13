internal class Program
{
    static void Fill(double[,] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++) 
            {
                arr[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
                Console.Write($"{arr[i, j],6} ");
            }
            Console.WriteLine();
        }
    }
    static void Print(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }

    private static void Main(string[] args)
    {
        int[] A = new int[5];
        double[,] B = new double[3, 4];
        Console.WriteLine("After you enter a digit press enter and do it 5 times:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = int.Parse(Console.ReadLine());   
        }

        Console.WriteLine("\nArr A:");
        Print(A);

        Console.WriteLine("\nArr B:");
        Fill(B);

        double maxElement = A[0], minElement = A[0];
        foreach (var item in A)
        {
            if (item > maxElement) 
                maxElement = item;
            if (item < minElement) 
                minElement = item;
        }

        foreach (var item in B)
        {
            if (item > maxElement) 
                maxElement = item;
            if (item < minElement) 
                minElement = item;
        }

        double tsum = 0, tproduct = 1;
        foreach (var item in A)
        {
            tsum += item;
           tproduct *= item;
        }
        foreach (var item in B)
        {
            tsum += item;
            tproduct *= item;
        }
        int sumA = 0;
        foreach (var e in A)
        {
            if (e % 2 == 0) 
                sumA += e;
        }

        double oddCol = 0;
        
        for(int q = 0;q < B.GetLength(1); q++)
        {
            if(q % 2 != 0)
            {
                for (int j = 0; j < B.GetLength(0); j++)
                {
                    oddCol += B[j, q];
                }
            }
            
        }

        Console.WriteLine($"\nMax element: {maxElement}");
        Console.WriteLine($"Min element: {minElement}");
        Console.WriteLine($"Total sum: {tsum}");
        Console.WriteLine($"Total product: {tproduct}");
        Console.WriteLine($"Sum of even elements in arr A: {sumA}");
        Console.WriteLine($"Sum of elements in odd columns of arr B: {oddCol}");

    }
}