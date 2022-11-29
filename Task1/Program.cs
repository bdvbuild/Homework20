using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
//-метод получает входным параметром переменную типа double;
//-метод возвращает значение типа double, которое является результатом вычисления.
//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
//-длину окружности по формуле D = 2 * π* R;
//-площадь круга по формуле S = π* R²;
//-объем шара.Формула V = 4 / 3 * π * R³.
//Методы должны быть объявлены как статические.


namespace Task1
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate mydelegate = Length;
            double l = mydelegate(r);
            Console.WriteLine($"Длина окружности = {l}");

            mydelegate = Area;
            double a = mydelegate(r);
            Console.WriteLine($"Площадь круга = {a}");

            mydelegate = Vol;
            double v = mydelegate(r);
            Console.WriteLine($"Объем шара = {v}");

            Console.ReadKey();
        }
        static double Length(double r)
        {
            double l = 2 * Math.PI * r;
            return l;
        }
        static double Area(double r)
        {
            double a = Math.PI * r * r;
            return a;
        }
        static double Vol(double r)
        {
            double v = (Math.PI * r * r * r * 4 / 3);
            return v;
        }

    }
}
