using System;

class ThucHanh6
{
    static void Main()
    {
        // Nhập dữ liệu
        Console.Write("Nhập chiều dài (số thực dương): ");
        double dai = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập chiều rộng (số thực dương): ");
        double rong = Convert.ToDouble(Console.ReadLine());

        // Kiểm tra điều kiện hợp lệ
        if (dai <= 0 || rong <= 0)
        {
            Console.WriteLine("Chiều dài và chiều rộng phải là số thực dương!");
        }
        else
        {
            // Tính chu vi và diện tích
            double chuVi = 2 * (dai + rong);
            double dienTich = dai * rong;

            // In kết quả
            Console.WriteLine("Chu vi hình chữ nhật = {0}", chuVi);
            Console.WriteLine("Diện tích hình chữ nhật = {0}", dienTich);
        }

        Console.WriteLine("Nhấn Enter để thoát...");
        Console.ReadLine();
    }
}
