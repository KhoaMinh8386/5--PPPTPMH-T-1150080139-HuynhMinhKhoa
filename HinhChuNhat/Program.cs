using System;

class Program
{
    static void Main()
    {
        // Nhập dữ liệu
        Console.Write("Nhập vào chiều dài: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập vào chiều rộng: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Tính chu vi và diện tích
        double chuVi = (a + b) * 2;
        double dienTich = a * b;

        // Hiển thị kết quả
        Console.WriteLine("Chu vi là: " + chuVi);
        Console.WriteLine("Diện tích là: " + dienTich);

        // Giữ màn hình console chờ Enter
        Console.WriteLine("Nhấn Enter để thoát...");
        Console.ReadLine();
    }
}
