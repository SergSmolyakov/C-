//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

System.Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(System.Console.ReadLine());

int Akkerman(int m, int n)
{
  int result = 0;
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
    result = Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
System.Console.WriteLine(Akkerman(m,n));
