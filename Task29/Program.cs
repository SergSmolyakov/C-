//: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Write("Массив из 8 элементов: ");
int num = 8;

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);

void FillArrayRandom(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i <= array.Length - 1; i++)
    array[i] = rand.Next(0, 33);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}

