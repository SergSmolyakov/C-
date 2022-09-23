System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int reversive = 0;
while (num1 > 0)
{
    int r = num1 % 10;
    reversive = reversive * 10 + r;
    num1 = num1 / 10;
}
if (reversive == num)
{
    System.Console.WriteLine($"Число {num} => да, является палиндромом");
}
else
{
    System.Console.WriteLine($"Число {num} => нет, не является палиндромом");
}