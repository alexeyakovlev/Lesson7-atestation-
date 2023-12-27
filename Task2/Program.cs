//Напишите программу вычисления функции
//Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

Console.Clear();

int Akkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  if (n == 0)
  {
    return Akkerman(m - 1, 1);
  }
  else
  {
    return Akkerman(m - 1, Akkerman(m, n - 1));
  }
}

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());
int ackFunction = Akkerman(m, n);
Console.WriteLine($"Функция аккермана = {ackFunction}");