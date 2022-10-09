//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10); 
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 3} ");
        }
        Console.Write(" |");
        Console.WriteLine("");               
    }         
    Average(numbers);
}

void Average(int[,] array)
{     
   for (int i = 0; i < array.GetLength(1); i++)
    {     
        double average = 0;   
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average += array[j,i];             
        }
        average = average/rows; 
        System.Console.WriteLine(" ");                    
        System.Console.Write(average);
    }  
   
}
    
