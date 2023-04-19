// Итоговая контрольная работа по основному блоку
// Урок 1. Контрольная работа
// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

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

void FillArrayAndMoveToNewArray(int size)
{
  int ii = 0;
  string[] arrayFirst = new string[size];
  string[] arraySecond = new string[arrayFirst.Length / 2 + (arrayFirst.Length % 2)];
  for (int i = 0; i < arrayFirst.Length; i++)
  {
    Console.Write($"Введите любое значение для индекса {i} из {arrayFirst.Length-1}: ");
    arrayFirst[i] = Console.ReadLine();
    if(i % 2 == 0)
    {
      arraySecond[ii] = arrayFirst[i];
      ii++;
    }
  }
}

Console.Clear(); Console.Write("Please enter the size of the array: ");
int sizeArray = IsNumbers(Console.ReadLine());
FillArrayAndMoveToNewArray(sizeArray);
Console.WriteLine($"Благодарю, что сегодня {DateTime.Now} Вы воспользовались моей программой.");