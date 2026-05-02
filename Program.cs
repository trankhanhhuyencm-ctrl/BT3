using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1.
            Console.Write("Nhập số thứ nhất: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} : {b} = {a / b}");
            //2.
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
            //3.
            Console.Write("Nhập quãng đường (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập giờ: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập phút: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập giây: ");
            int s = Convert.ToInt32(Console.ReadLine());

            double totalHours = h + m / 60.0 + s / 3600.0;

            double speedKm = distance / totalHours;
            double speedMiles = speedKm * 0.621371;

            Console.WriteLine("Tốc độ: " + speedKm + " km/h");
            Console.WriteLine("Tốc độ: " + speedMiles + " miles/h");
            //4.
            Console.Write("Nhập bán kính: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double surface = 4 * Math.PI * r * r;
            double volume = (4.0 / 3) * Math.PI * r * r * r;

            Console.WriteLine("Diện tích: " + surface);
            Console.WriteLine("Thể tích: " + volume);
            //5.
            Console.Write("Nhập 1 ký tự: ");
            char c = Convert.ToChar(Console.ReadLine());

            if (char.IsDigit(c))
            {
                Console.WriteLine("Là chữ số");
            }
            else if ("aeiouAEIOU".Contains(c))
            {
                Console.WriteLine("Là nguyên âm");
            }
            else
            {
                Console.WriteLine("Ký tự khác");
            }
        }
    }
}