// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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

void FillMatrix(double[,] mat)
{
  int row = mat.GetLength(0);
  int columns = mat.GetLength(1);
  Random numbers = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        mat[i, j] = new Random().Next(1, 10);
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
        Console.Write($"{mat[i, j]} ");
        }
    Console.WriteLine();
    }
}

void GetSrZn(double[,] mat) 
{
int row = mat.GetLength(0);
int columns = mat.GetLength(1);
for (int j = 0; j < columns; j++)
{
    double sum = 0;
    for (int i = 0; i < row; i++)
    {
        sum = (sum + mat[i, j]);
    }
    sum = sum / row;

    Console.Write(sum + "; ");
}
}

int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
double [,] matrix = new double [rows, columns];
//double[] array = GetSrZn(matrix); 
CreateArray(rows, columns);
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Среднее арифметическое столбцов от 1 до " + columns);
GetSrZn(matrix);
//Console.WriteLine($"Среднее арифметическое в столбце {columns + 1}: {}");
