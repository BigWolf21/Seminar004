// Задача 27: Напишите метод, который принимает
// на вход число и выдаёт сумму цифр в числе.
// 
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int numberlen)
{
  int index = 0;
  while (numberlen > 0)
  {
    numberlen /= 10;
    index++;
  }
  return index;
}

int Sum(int number, int len)
{
  int summa = 0;
  for (int index = 1; index <= len; index++)
  {
    summa += number % 10;
    number /= 10;
  }
  return summa;
}

int number = GetNumber("Введите число - ");
int len = NumberLen(number);
int summa = Sum(number, len);

// Console.WriteLine("Количество цифр " + len);
Console.WriteLine("Сумма цифр в числе " + number + " равно " + summa);