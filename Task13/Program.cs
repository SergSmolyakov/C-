// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.WriteLine("Введи цифру от 1 до 7, обозначающую день недели ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void ChekingTheDayWeek (int dayNum) {
    if(dayNum == 6 || dayNum == 7) {
        System.Console.WriteLine("Это выходной день? => Да");
    }
    else if (dayNum < 1 || dayNum > 7) {
        System.Console.WriteLine("Введите число от 1 до 7, веденное вами число вне этого диапазона");
    }
    else
    {
        System.Console.WriteLine("Это выходной день? => Нет");
    }
}
ChekingTheDayWeek(dayNum);