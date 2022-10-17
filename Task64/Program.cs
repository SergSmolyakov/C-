//Задача 64: Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
NaturalNum(num);

void NaturalNum(int num)
{
    if (num == 0) return;    
    System.Console.Write($"{num} ");
    NaturalNum(num - 1);
}
