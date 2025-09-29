using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhập phần tử arr[{0}]: ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i]; // cộng dồn luôn khi nhập
        }

        Console.WriteLine("Tổng các phần tử trong mảng = " + sum);
    }
}
