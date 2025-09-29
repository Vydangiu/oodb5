using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NgoThaoVy_1150080123_B5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Nhap chieu dai: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Nhap chieu rong: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //double P = (a + b) * 2;
            //double S = a * b;
            //Console.WriteLine("Chu vi la: " + P);
            //Console.WriteLine("Dien tich la: " + S);

            //Tìm số lớn hơn trong 2 số nguyên a và b được nhập vào từ bàn phím. 
            //Console.Write("Nhập số nguyên a: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhập số nguyên b: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int max;
            //if (a > b)
            //    max = a;
            //else
            //    max = b;

            //Console.WriteLine("Số lớn hơn là: " + max);


            //// Thực hành 3: Tìm số có giá trị lớn nhất trong 3 số nguyên a, b, c được nhập vào  từ bàn phím.
            //Console.Write("Nhập a: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhập b: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhập c: ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //int max = a;
            //if (b > max) max = b;
            //if (c > max) max = c;

            //Console.WriteLine("Số lớn nhất là: " + max);

            // Thực hành 4: Viết chương trình nhập vào 1 số nguyên, kiểm tra số đó là chẵn hay lẻ.
            //Console.Write("Nhập năm: ");
            //int nam = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhập tháng: ");
            //int thang = Convert.ToInt32(Console.ReadLine());

            //switch (thang)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Tháng có 31 ngày.");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Tháng có 30 ngày.");
            //        break;
            //    case 2:
            //        if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
            //            Console.WriteLine("Tháng có 29 ngày.");
            //        else
            //            Console.WriteLine("Tháng có 28 ngày.");
            //        break;
            //    default:
            //        Console.WriteLine("Tháng không hợp lệ!");
            //        break;
            //}

            // Thực hành 5: Viết chương trình nhập vào một số nguyên n. Cho biết:
            // Nhập dữ liệu
            //Console.Write("Nhập vào số nguyên n: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //// a) Kiểm tra chẵn hay lẻ
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("a) " + n + " là số chẵn.");
            //}
            //else
            //{
            //    Console.WriteLine("a) " + n + " là số lẻ.");
            //}

            //// b) Kiểm tra âm hay không âm
            //if (n < 0)
            //{
            //    Console.WriteLine("b) " + n + " là số âm.");
            //}
            //else
            //{
            //    Console.WriteLine("b) " + n + " là số không âm.");
            //}

            // Thực hành 6: Viết chương trình nhập vào 2 số thực dương chỉ chiều dài và chiều  rộng của hình chữ nhật.In ra màn hình chu vi và diện tích của hình chữ nhật đó. 
            // Nhập dữ liệu
            //Console.Write("Nhập chiều dài hình chữ nhật: ");
            //double chieuDai = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Nhập chiều rộng hình chữ nhật: ");
            //double chieuRong = Convert.ToDouble(Console.ReadLine());

            //// Tính chu vi và diện tích
            //double chuVi = 2 * (chieuDai + chieuRong);
            //double dienTich = chieuDai * chieuRong;

            //// Hiển thị kết quả
            //Console.WriteLine("Chu vi hình chữ nhật là: " + chuVi);
            //Console.WriteLine("Diện tích hình chữ nhật là: " + dienTich);

            //Thực hành 7: Viết chương trình nhập vào ba số thực chỉ độ dài của ba đoạn  thẳng. Kiểm tra nếu ba đoạn thẳng này lập thành được một tam giá thì hiển thị  chu vi và diện tích của tam giác đó. 
            //// Nhập dữ liệu
            //Console.Write("Nhập cạnh a: ");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Nhập cạnh b: ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Nhập cạnh c: ");
            //double c = Convert.ToDouble(Console.ReadLine());

            //// Kiểm tra điều kiện tam giác
            //if (a + b > c && a + c > b && b + c > a)
            //{
            //    Console.WriteLine("Ba cạnh này lập thành một tam giác.");

            //    // Chu vi
            //    double P = a + b + c;
            //    Console.WriteLine("Chu vi tam giác: " + P);

            //    // Diện tích theo công thức Heron
            //    double p = P / 2; // nửa chu vi
            //    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //    Console.WriteLine("Diện tích tam giác: " + S);
            //}
            //else
            //{
            //    Console.WriteLine("Ba cạnh này KHÔNG lập thành một tam giác.");
            //}

            //Thực hành 8: Viết chương trình giải phương trình bậc 2: ax2 + bx + c = 0. 
            //// Nhập dữ liệu
            //Console.Write("Nhập hệ số a: ");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Nhập hệ số b: ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Nhập hệ số c: ");
            //double c = Convert.ToDouble(Console.ReadLine());

            //// Xử lý
            //if (a == 0)
            //{
            //    // Trường hợp phương trình trở thành bậc 1: bx + c = 0
            //    if (b == 0)
            //    {
            //        if (c == 0)
            //            Console.WriteLine("Phương trình có vô số nghiệm.");
            //        else
            //            Console.WriteLine("Phương trình vô nghiệm.");
            //    }
            //    else
            //    {
            //        double x = -c / b;
            //        Console.WriteLine("Phương trình bậc nhất có nghiệm: x = " + x);
            //    }
            //}
            //else
            //{
            //    // Phương trình bậc 2
            //    double delta = b * b - 4 * a * c;

            //    if (delta < 0)
            //    {
            //        Console.WriteLine("Phương trình vô nghiệm (Delta < 0).");
            //    }
            //    else if (delta == 0)
            //    {
            //        double x = -b / (2 * a);
            //        Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = " + x);
            //    }
            //    else
            //    {
            //        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            //        Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
            //        Console.WriteLine("x1 = " + x1);
            //        Console.WriteLine("x2 = " + x2);
            //    }
            //}

            //Thực hành 9: Tính tổng các phần tử trong mảng.
            //// Khai báo mảng
            //int[] arr = { 3, 5, 1, 4, 9 };

            //// Cách 1: Dùng vòng lặp
            //int tong = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    tong += arr[i];
            //}
            //Console.WriteLine("Tổng các phần tử trong mảng (for): " + tong);

            //// Cách 2: Dùng LINQ
            //int tong2 = arr.Sum();
            //Console.WriteLine("Tổng các phần tử trong mảng (LINQ): " + tong2);

            //Thực hành 10: Dùng giải thuật sắp xếp chọn (Selection Sort) để sắp xếp tăng  dần mảng các số nguyên. Mảng các số nguyên được lưu trong tệp văn bản có tên  là “input_array.txt”. 
            // Đọc mảng từ file
            //// Đọc dữ liệu từ file
            //string[] lines = File.ReadAllText("input_array.txt").Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            //int n = lines.Length;
            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(lines[i]);
            //}

            //// Selection Sort
            //for (int i = 0; i < n - 1; i++)
            //{
            //    int minIndex = i;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[j] < arr[minIndex])
            //        {
            //            minIndex = j;
            //        }
            //    }
            //    // Hoán đổi
            //    int temp = arr[i];
            //    arr[i] = arr[minIndex];
            //    arr[minIndex] = temp;
            //}

            //Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}

            //Thực hành 11: Chèn thêm một số nguyên được nhạp vào từ bàn phím vào mảng  đã sắp xếp tăng dần nhưng không làm mất tính tăng dần của mảng. 
            // Mảng đã sắp xếp tăng dần
            int[] arr = { 1, 3, 5, 7, 9 };

            Console.Write("Nhập số nguyên cần chèn: ");
            int x = Convert.ToInt32(Console.ReadLine());

            // Tạo mảng mới có thêm 1 phần tử
            int[] newArr = new int[arr.Length + 1];
            int i = 0, j = 0;
            bool daChen = false;

            while (i < arr.Length)
            {
                if (!daChen && x < arr[i])
                {
                    newArr[j++] = x;
                    daChen = true;
                }
                else
                {
                    newArr[j++] = arr[i++];
                }
            }

            // Nếu x lớn nhất thì chèn cuối
            if (!daChen)
                newArr[j] = x;

            // In kết quả
            Console.WriteLine("Mảng sau khi chèn:");
            foreach (int val in newArr)
            {
                Console.Write(val + " ");
            }




        }
    }
}
