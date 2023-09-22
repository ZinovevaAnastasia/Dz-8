// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
 {
   for (int j = 0; j < matrix.GetLength(1); j++)
   {
    matrix[i, j] = rnd.Next(min, max + 1);
   }
 }
return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j], 6}");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] array1, int[,] array2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      result[i,j] = sum;
    }
  }
}

Console.WriteLine("Первая матрица");
int[,] array1 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(array1);
Console.WriteLine("Вторая матрица");
int[,] array2 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(array2);
int[,] result = new int[2,2];
MultiplyMatrix(array1, array2, result);
Console.WriteLine("Произведение первой и второй матриц:");
PrintMatrix(result);

