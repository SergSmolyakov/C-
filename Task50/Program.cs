//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Проверим позицию");
Console.WriteLine("Введите номер строки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] test = new int[rows, columns];
int[,] numbers = new int[5, 8];

FillArrayRandomNumbers(numbers);
Examination();

void FillArrayRandomNumbers(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(-100, 999); 
        }
    }
}

int TestArray1(int[,] array)
{
   return array.GetLength(0);   
}

int TestArray2(int[,] array)
{
   return array.GetLength(1);   
}

void Examination()
{
    PrintArray(numbers);
    if (rows > TestArray1(numbers) || columns > TestArray2(numbers) )
    {
        System.Console.WriteLine($"{rows}, {columns} => такого элемента в массиве нет");
    }
    else
    {
        System.Console.WriteLine($"На позиции {rows}, {columns} => {numbers[rows,columns]}");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 1; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 5} ");
        }
        Console.Write(" |");
        Console.WriteLine("");
    }
}


