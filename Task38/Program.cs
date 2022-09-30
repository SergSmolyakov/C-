// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(System.Console.ReadLine());

Console.Write("Введите max массива: ");
int maxsize = Convert.ToInt32(System.Console.ReadLine());

Console.Write("Введите min массива: ");
int minsize = Convert.ToInt32(System.Console.ReadLine());

double[] arrayGlobal = new double[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);
MaxNum(arrayGlobal);

void FillArrayRandom(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i <= array.Length - 1; i++)    
    array[i] = Math.Round(rand.NextDouble() * (maxsize - minsize) + minsize, 2);
}

void MaxNum(double[] array)
{
    double maxNum = 0;
    double minNum = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
        else
        minNum = array[i];
    }
    double result = maxNum - minNum;    
    System.Console.WriteLine($" => {result}");
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}


