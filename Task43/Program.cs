// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Найдем точку пересечения двух прямых: ");

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(System.Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(System.Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(System.Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(System.Console.ReadLine());

double X(double num1, double num2, double num3, double num4)
{
    double x = (num2 - num1)/(num3 - num4);
    return x;
}

double Coordinate(double num1, double num2, double num3)
{
   double coordinate1 = num1 * num2 + num3;
   return coordinate1;  
}

System.Console.WriteLine($"Точка пересечения двух прямых: ({Coordinate(k1, X(b1, b2, k1, k2), b1)};{Coordinate(k2, X(b1, b2, k1, k2), b2)})");