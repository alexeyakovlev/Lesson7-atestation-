//Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежутке
//от M до N. 
//Использовать рекурсию, не использовать циклы.

Console.Clear();

void PrintNaturalNumbers(int m, int n)
{
  if (n == m)
  {
    Console.Write(n + " ");
    return;
  }
  PrintNaturalNumbers(m, n - 1);
  Console.Write(n + " ");
}

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(m, n);