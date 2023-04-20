// ########################################################################
// # !!! Решение не для зачёта, просто альтернативный вариант решения !!! #
// # !!! без использование итераций и рекурсий !!!                        #
// ########################################################################

Console.Clear(); Console.Write("Введите значения массива через пробел: ");
string[] ArrayFirst = Console.ReadLine().Split(" ").ToArray();
int i = 0;

foreach (string elem in ArrayFirst)
{
  if (elem.Length <= 3) i++;
}

string[] ArraySecond = new string [i];
i = 0;

foreach (string elem in ArrayFirst)
{
  if (elem.Length <= 3)
  {
    ArraySecond[i] = elem;
    i++;
  }
}

Console.WriteLine($"Creation ArrayFirst complied - [{string.Join(", ", ArrayFirst)}]");
Console.WriteLine($"Creation ArraySecond complied - [{string.Join(", ", ArraySecond)}]");