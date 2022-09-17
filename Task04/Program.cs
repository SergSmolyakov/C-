// Задача 4: Напишите программу, которая 
// 1. Принимает на вход три числа 
// 2. Выдаёт максимальное из этих чисел.
// 3. Выводит результат.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое целое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");

int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 || num3 < num1)
{   
    Console.WriteLine($"Наибольшее число {num1}");
} 

if(num2 > num1 && num3 < num2 )
{
    Console.WriteLine($"Наибольшее число {num2}");
}
if(num3 > num1 && num2 < num3)
 Console.WriteLine($"Наибольшее число {num3}");