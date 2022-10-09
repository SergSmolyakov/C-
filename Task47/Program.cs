//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
void FillArrayRandomNumbers(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.NextDouble(), 2); 
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 5} ");
        }
        Console.Write(" |");
        Console.WriteLine("");
    }
}


