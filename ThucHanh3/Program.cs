using System;

class ThucHanh3
{
    static void Main()
    {
        // Nhập dữ liệu
        Console.Write("Nhập vào số nguyên a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập vào số nguyên b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập vào số nguyên c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Tìm số max trong 3 số nguyên
        int max;
        if (a >= b && a >= c)
        {
            max = a;
        }
        else if (b >= a && b >= c)
        {
            max = b;
        }
        else
        {
            max = c;
        }

        // Hiển thị kết quả
        Console.WriteLine("Số lớn nhất trong 3 số là: {0}", max);

        Console.WriteLine("Nhấn Enter để thoát...");
        Console.ReadLine();
    }
}
