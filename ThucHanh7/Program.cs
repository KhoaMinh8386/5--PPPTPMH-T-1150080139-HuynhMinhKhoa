using System;

class Program
{
    static void Main()
    {
        // Nhập 3 cạnh
        Console.Write("Nhập cạnh a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập cạnh b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập cạnh c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Kiểm tra điều kiện lập tam giác
        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Ba cạnh này lập thành một tam giác.");

            // Chu vi
            double P = a + b + c;
            Console.WriteLine("Chu vi tam giác = " + P);

            // Nửa chu vi
            double p = P / 2;

            // Diện tích theo công thức Heron
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Diện tích tam giác = " + S);
        }
        else
        {
            Console.WriteLine("Ba cạnh này KHÔNG lập thành tam giác.");
        }
    }
}
