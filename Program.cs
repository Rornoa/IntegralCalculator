using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            trapeziumMethod();
            rectangleMethod();
            simpsonsParabolaMethod();

        }
            static void rectangleMethod() {
            //задаём границы отрезка функции
            const double a = 0;
            const double b = Math.PI;
            //определяем число интервалов
            Console.Write("Введите значение, влияющее на точность: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //вычисляемшаг
            double k = (b - a) / n;
            //инициализируем переменную, в которую будет запоминаться значение интеграла
            double Integral = 0;
            //производим пошаговое приращение переменной на слагаемое, определенное методом прямоугольников
            for (double x = a + k; x <= b; x += k)
            {
                Integral += k * x * Math.Sin(x);
            }
            //вывод результата
            Console.Write("Определенный интеграл данной функции = " + Integral);
            Console.ReadKey();
            }

        static void trapeziumMethod() {
            //задаём границы отрезка функции
            const double a = 0;
            const double b = Math.PI;
            //определяем число интервалов
            Console.Write("Введите значение, влияющее на точность: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //вычисляемшаг
            double k = (b - a) / n;
            //инициализируем переменную, в которую будет запоминаться значение интеграла
            double Integral = 0;
            //производим пошаговое приращение переменной на слагаемое, определенное методом трапеций
            for (double x = a + k; x <= b; x += k)
            {
                Integral += k * ((x * Math.Sin(x)) + ((x + k) * Math.Sin(x + k))) / 2;
            }
            //вывод результата
            Console.Write("Определенный интеграл данной функции = " + Integral);
            Console.ReadKey();
        }

        static void simpsonsParabolaMethod() {
            //задаём границы отрезка функции
            const double a = 0;
            const double b = Math.PI;
            //определяем число интервалов
            Console.Write("Введите значение, влияющее на точность: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //вычисляемшаг
            double h = (b - a) / (2 * n);
            /*инициализируем переменную, в которую будет запоминаться значение интеграла, 
                        заранее учитывая известные слагаемые*/
            double Integral = (a * Math.Sin(a)) + (b * Math.Sin(b));
            //задаём счётчик слагаемых, так как коэффиценты чётных и нечётных слагаемых различны
            int k = 1;
            //производим пошаговое приращение переменной на слагаемое, определенное методом Симсона
            for (double x = a + h; x < b; x += h)
            {
                if (k % 2 == 1)
                {
                    Integral += 4 * (x * Math.Sin(x));
                    k++;
                }
                else
                {
                    Integral += 2 * (x * Math.Sin(x));
                    k++;
                }
            }
            Integral *= h / 3;
            //выводрезультата
            Console.Write("Определенныйинтегралданнойфункции = " + Integral);
            Console.ReadKey();
        }
    }
}

