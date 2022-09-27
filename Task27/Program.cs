//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumOfTheNumbersInNumber(int num)
{
    int num1 = num;
    int sumNum = 0;
    
    while (num1 > 0)
    {
        int r = num1 % 10;
        sumNum = sumNum + r;
        num1 = num1 / 10;
    }
    return sumNum;
}

System.Console.WriteLine("Напишите число а я покажу сумму его цифр");
int num = Convert.ToInt32(Console.ReadLine());

int res = SumOfTheNumbersInNumber(num);
System.Console.WriteLine(res);
