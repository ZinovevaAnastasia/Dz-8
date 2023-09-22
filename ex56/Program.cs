// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine($"Введите размер массива и диапазон случайных значений:");
int m = InputNumbers("Введите количество столбцов: ");
int n = InputNumbers("Введите количество строк: ");
int range = InputNumbers("Введите диапазон: от 0 до ");

int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);

int minLine = 0;
int minsumLine = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int t = SumLine(array, i);
  if (minsumLine > t)
  {
    minsumLine = t;
    minLine = i;
  }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {minLine+1} строкa с суммой элементов {minsumLine}");

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j], 4}");
    }
    Console.WriteLine();
  }
}

int SumLine(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}