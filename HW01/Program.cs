// Задача 25: Напишите метод, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 
// 2, 4 -> 16

int GetNumber(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

int Main(int numberA, int numberB)
{
int degree = numberA;
int index = 0;
for (index=1; index < numberB; index++)
{
  degree = degree * numberA;
}
return degree;
}

int numberA = GetNumber("Введите число A ");
int numberB = GetNumber("Введите число B ");
int degree = Main(numberA, numberB);
Console.WriteLine("Число " + numberA + " в степени " + numberB + " равно " + degree);