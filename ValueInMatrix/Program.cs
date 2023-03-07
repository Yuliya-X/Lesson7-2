// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// подзадачи: задать размер руками, создать, заполнить, напечатать массив, задать значениепозиции, напечатать значение или нет 

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

void FillMatrix(int[,] mat, int min = 0, int max = 10)
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

void GetValue(int [,] mat, int n, int m)
{
    int row = mat.GetLength(0);
    int columns = mat.GetLength(1);
    if (n > row && m > columns)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"На вашей позиции {n}, {m} находится элемент, равный {mat[n, m]}");
    }
}

int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
int n = Input("Введите индекс строки: ");
int m = Input("Введите индекс столбца: ");
int [,] matrix = new int [rows, columns];
CreateArray(rows, columns);
FillMatrix(matrix);
PrintMatrix(matrix);
GetValue(matrix, n, m);