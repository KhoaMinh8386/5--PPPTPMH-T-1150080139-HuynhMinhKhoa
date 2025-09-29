using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Đọc dữ liệu từ file
        string filePath = "input_array.txt";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Không tìm thấy file input_array.txt");
            return;
        }

        string[] lines = File.ReadAllText(filePath).Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int n = lines.Length;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(lines[i]);
        }

        Console.WriteLine("Mảng ban đầu:");
        PrintArray(arr);

        // Selection Sort
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Đổi chỗ phần tử nhỏ nhất với arr[i]
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }

        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
        PrintArray(arr);
    }

    // Hàm in mảng
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
