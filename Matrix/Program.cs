// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Input(string msg)
{
  bool flag = false;
  int value = 0;
  while (!flag)
  {
    Console.Write(msg + " ");
    flag = int.TryParse(Console.ReadLine(), out value);
  }
  return value;
}

int[,] CreateArray(int m, int n) => new int[m, n];

void FillMatrix(int [,] mat, int min = -10, int max = 10)
{
  int row = mat.GetLength(0);
  int columns = mat.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        mat[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintMatrix(int [,] mat)
{
  int row = mat.GetLength(0);
  int columns = mat.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        Console.Write($"{mat[i, j], 3} ");
        }
    Console.WriteLine();
    }
}


int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");


int [,] matrix = new int [rows, columns];
//PrintMatrix(matrix);
//Console.WriteLine();
FillMatrix(matrix);
CreateArray(rows, columns);
PrintMatrix(matrix);
