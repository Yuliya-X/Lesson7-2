// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// подзадачи: задать размер руками, создать, заполнить, напечатать 

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

double[,] CreateArray(int m, int n) => new double[m, n];

void FillMatrix(double[,] mat, int min = -100, int max = 100)
{
  int row = mat.GetLength(0);
  int columns = mat.GetLength(1);
  Random numbers = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        mat[i, j] = Math.Round(numbers.Next(min, max) * 0.1, 1); 
        }
    }
}


void PrintMatrix(double [,] mat)
{
  int row = mat.GetLength(0);
  int columns = mat.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        Console.Write("{0,05}", mat[i, j]);
        }
    Console.WriteLine();
    }
}

int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
double [,] matrix = new double [rows, columns];
CreateArray(rows, columns);
FillMatrix(matrix);
PrintMatrix(matrix);