// Задача 2: Напишите программу, которая: 
// 1. На вход принимает два числа 
// 2. Выдаёт, какое число большее, а какое меньшее.
// 3. Вывод результата.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое целое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
   Console.WriteLine($"Наибольшее число {num1}"); 
}
else
{
    Console.WriteLine($"Наибольшее число {num2}");
};



