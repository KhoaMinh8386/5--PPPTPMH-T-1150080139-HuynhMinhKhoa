using System;

class Program
{
    static void Main()
    {
        // Mảng đã sắp xếp tăng dần sẵn
        int[] arr = { 1, 2, 3, 5, 8, 9 };
        int n = arr.Length;

        Console.WriteLine("Mảng ban đầu:");
        PrintArray(arr);

        // Nhập số cần chèn
        Console.Write("Nhập số nguyên cần chèn: ");
        int x = Convert.ToInt32(Console.ReadLine());

        // Tạo mảng mới có thêm 1 phần tử
        int[] newArr = new int[n + 1];
        bool inserted = false;
        int k = 0;

        for (int i = 0; i < n; i++)
        {
            if (!inserted && x < arr[i])
            {
                newArr[k++] = x;   // chèn x trước arr[i]
                inserted = true;
            }
            newArr[k++] = arr[i];
        }

        // Nếu x lớn hơn tất cả thì chèn vào cuối
        if (!inserted)
        {
            newArr[k] = x;
        }

        Console.WriteLine("Mảng sau khi chèn:");
        PrintArray(newArr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
