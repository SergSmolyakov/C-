// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел: ");
int num = Convert.ToInt32(System.Console.ReadLine());
int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);
NumPositive(arrayGlobal);

void FillArrayRandom(int[] array)
{
    System.Console.WriteLine($"Введите числа: ");
    for (int i = 0; i <= array.Length - 1; i++)    
    array[i] = Convert.ToInt32(System.Console.ReadLine());    
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
       if (array[i] > 0)
       {
        j++;
       } 
    }
    System.Console.WriteLine($" => {j}");
}