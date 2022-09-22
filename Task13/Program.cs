// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.WriteLine("Введи число и я покажу третью цифру ");
int num = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(num);
if(numStr.Length > 2){
    System.Console.WriteLine("Третья цифра => " + numStr[2]);
}
else
{
    System.Console.WriteLine("=> нет третьей цифры");
}