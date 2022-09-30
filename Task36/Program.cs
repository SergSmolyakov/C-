// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(System.Console.ReadLine());

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);
SumOddNum(arrayGlobal);

void FillArrayRandom(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i <= array.Length - 1; i++)
    array[i] = rand.Next(-100, 999);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}

void SumOddNum(int[] array)
{
    int resSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (i % 2 != 0)
        {
            resSum = resSum + array[i];
        }
    }
    System.Console.WriteLine($" => {resSum} Сумма нечетных элементов массива ");
}

