// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


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

double num = 3.09987565; // 3.09
double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
System.Console.WriteLine(numRound);
