// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int DegreeNum(int num1, int num2){
  int result = 1;
  for(int i = 1; i <= num2; i++){
    result = result * num1;
  }
      return result;
}

  Console.Write("Введите число которое нужно возвести в степень: ");
  int num1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите степень: ");
  int num2 = Convert.ToInt32(Console.ReadLine());

  int degree = DegreeNum(num1, num2);
  Console.WriteLine($"{num1} в степени {num2} будет равняться {degree}. ");