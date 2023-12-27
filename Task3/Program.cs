//Задайте произвольный массив.
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

Console.Clear();

int[] Array(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(10);
  }
  return array;
}

int[] Yarra(int[] array, int index)
{
  if (index <= 0)
  {
    return array;
  }
  int yarra = array[index];
  array[index] = array[array.Length - index - 1];
  array[array.Length - index - 1] = yarra;
  return Yarra(array, index -= 2);
}

string PrintArray(int[] array)
{
  return string.Join(", ", array);
}

int ReadInt(string msg)
{
  Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());
}

//-----------

int n = ReadInt("Введите размер массива: ");
int[] array = Array(n);
Console.WriteLine(PrintArray(array));
Console.WriteLine("Перевернутый массив:");
Console.WriteLine(PrintArray(Yarra(array, n-1)));