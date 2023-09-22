//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateMatrixRndInt(int rows, int columns, int d, int min, int max)
{
int[,,] matrix = new int[rows, columns, d];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
 {
   for (int j = 0; j < matrix.GetLength(1); j++)
   {
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
    if (min < max)
    {
        matrix[i, j, k] = min;
        min++;
    }
    }
   }
 }
return matrix;
}

void PrintMatrix(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write( $"{matrix[i,j,k]} ({i}, {j}, {k}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

int[,,] array1 = CreateMatrixRndInt(2, 2, 2, 10, 25);
PrintMatrix(array1);

