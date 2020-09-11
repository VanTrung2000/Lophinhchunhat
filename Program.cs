using System;
using System.Security;

namespace chividientich
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap width:");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap height:");
            double height = Double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("Tinh chu vi dien tich HCN co: \n" + rectangle.Display());
            Console.WriteLine("Chu vi hinh chu nhat: " + rectangle.Chuvi());
            Console.WriteLine("Dien tich hinh chu nhat la: " + rectangle.Dientich());
            Console.ReadLine();
        }
    }
}
