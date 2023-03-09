Console.Write("Введите количество строк в двумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в двумерном массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Метод, который заполняет двумерный массив целыми числами из рандома
/// </summary>
/// <param name="rows">Количество строк в массиве</param>
/// <param name="cols">Количество столбцов в массиве</param>
/// <param name="minValue">Минимальная цифра для рандома</param>
/// <param name="maxValue">Максимальная цифра для рандома</param>
/// <returns>Возвращаем заполненный массив</returns>
int[,] GetMatrix (int rows, int cols, int minValue, int maxValue)
{
  int [,] matrix = new int[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i,j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return matrix;
}
/// <summary>
/// Метод, который печатает двумерный массив
/// </summary>
/// <param name="array2D">Двумерный массив целых чисел</param>
void PrintMatrix (int[,] array2D)
{
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      Console.Write(array2D[i,j] + "\t");
    }
    Console.WriteLine();
  }
}
int[,] matrix = GetMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);
/// <summary>
/// Метод, который сортирует строки в двумерном массиве по убыванию, через сортировку пузырьком
/// </summary>
/// <param name="array2D">Двумерный массив целых чисел</param>
void SortingMatrix(int[,] array2D)
{
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      for (int k = 0; k < cols - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}
SortingMatrix(matrix); 
Console.WriteLine();
PrintMatrix(matrix);