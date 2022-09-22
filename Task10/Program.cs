// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число и я покажу вторую цифру этого числа");
int num = Convert.ToInt32(Console.ReadLine());
if(num / 100 >= 1 && num / 100 <=9) {
    int res = num /10;
    res = res % 10;
    System.Console.WriteLine($"Вторая цифра числа {num} => {res}"); }
    else
    {
        System.Console.WriteLine($"Введите трехзначное число");
    }
