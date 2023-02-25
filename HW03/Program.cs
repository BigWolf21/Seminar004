// Задача 29: Напишите метод, который задаёт массив
// из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int GetNumber(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
  return new int[size];
}

void FillByUser(int[] array)
{
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    array[index] = GetNumber("Введите " + index + "элемент: ");
    index++;
  }

}

string Print(int[] array)
{
  string result = String.Empty;
  int len = array.Length;
  int index = 0;
  while (index < len)
  {
    result = result + " " + array[index];
    index++;
  }
  return result;
}

int size = GetNumber("Введите размер массива ");
int[] value = CreateArray(size);
FillByUser(value);
Console.WriteLine(Print(value));