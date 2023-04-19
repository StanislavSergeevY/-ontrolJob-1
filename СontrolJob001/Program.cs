// # Итоговая контрольная работа по основному блоку #
// ## Урок 1. Контрольная работа ##
// ###########################################################################
// # Задача: Написать программу, которая из имеющегося массива строк         #
// # формирует новый массив из строк, длина которых меньше,                  #
// # либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, #
// # либо задать на старте выполнения алгоритма.                             #
// # При решении не рекомендуется пользоваться коллекциями,                  #
// # лучше обойтись исключительно массивами.                                 #
// ###########################################################################

int IsNumbers(string n)
{
  bool numbers = int.TryParse(n, out int volume);
  while(numbers == false)
  {
    Console.Write("Вы ввели не число, повторите попытку: ");
    numbers = int.TryParse(Console.ReadLine(), out volume);
  }
  return volume;
}

int FillFirstArray(string[] arrayFirst)
{
  int count=0;
  for (int i = 0; i < arrayFirst.Length; i++)
  {   
    Console.Write($"Введите любое значение для индекса {i} из {arrayFirst.Length-1}: ");
    arrayFirst[i] = Console.ReadLine();
    if(arrayFirst[i].Length <= 3)
      count++;
  }
  return count;
}

void FillArraySecond(string[] arrayFirst, string[] arraySecond)
{
  int ii = 0;
  for (int i = 0; i < arrayFirst.Length; i++)
  {
    if(arrayFirst[i].Length <= 3)
    {
      arraySecond[ii] = arrayFirst[i];
      ii++;
    }
  }
}

Console.Clear(); Console.Write("Пожалуйста, введите размер массива: ");
string[] arrayFirst = new string[IsNumbers(Console.ReadLine())];
string[] arraySecond = new string[FillFirstArray(arrayFirst)];
FillArraySecond(arrayFirst, arraySecond);
Console.WriteLine($"Первый Массив: [{string.Join(", ", arrayFirst)}]");
Console.WriteLine($"Второй Массив: [{string.Join(", ", arraySecond)}]");
Console.WriteLine($"Благодарю, что сегодня {DateTime.Now} Вы воспользовались моей программой.");