using System;

class ThucHanh4
{
    static void Main()
    {
        // Nhập dữ liệu
        Console.Write("Nhập vào năm: ");
        int nam = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập vào tháng: ");
        int thang = Convert.ToInt32(Console.ReadLine());

        // Tìm số ngày trong tháng
        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Tháng {0} có 31 ngày!", thang);
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Tháng {0} có 30 ngày!", thang);
                break;

            case 2:
                // Kiểm tra năm nhuận
                if ((nam % 400 == 0) || ((nam % 4 == 0) && (nam % 100 != 0)))
                {
                    Console.WriteLine("Tháng 2 năm {0} có 29 ngày!", nam);
                }
                else
                {
                    Console.WriteLine("Tháng 2 năm {0} có 28 ngày!", nam);
                }
                break;

            default:
                Console.WriteLine("Tháng không hợp lệ!");
                break;
        }

        Console.WriteLine("Nhấn Enter để thoát...");
        Console.ReadLine();
    }
}
