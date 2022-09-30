// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(System.Console.ReadLine());

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);
NumPositive(arrayGlobal);


void FillArrayRandom(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i <= array.Length - 1; i++)
    array[i] = rand.Next(100, 999);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}

void NumPositive(int[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
       {
        j++;
       } 
    }
    System.Console.WriteLine($" => {j}");
}

