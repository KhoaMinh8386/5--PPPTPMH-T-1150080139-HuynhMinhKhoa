using System;

class ThucHanh5
{
    static void Main()
    {
        // Nhập dữ liệu
        Console.Write("Nhập vào số nguyên n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // a) Kiểm tra chẵn hay lẻ
        if (n % 2 == 0)
        {
            Console.WriteLine("{0} là số chẵn.", n);
        }
        else
        {
            Console.WriteLine("{0} là số lẻ.", n);
        }

        // b) Kiểm tra âm hay không âm
        if (n < 0)
        {
            Console.WriteLine("{0} là số âm.", n);
        }
        else
        {
            Console.WriteLine("{0} là số không âm.", n);
        }

        Console.WriteLine("Nhấn Enter để thoát...");
        Console.ReadLine();
    }
}
