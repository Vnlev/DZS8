// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber()
{
    string input = Console.ReadLine();
    int res = Convert.ToInt32(input);
    return res;
}

double[,] GenerateMatrix(int n, int m)
{
    Random rnd = new Random();

    double[,] matrix = new double[n, m];

    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            matrix[i, j] = rnd.Next(-100, 100) / 10.0;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            double x = matrix[i, j];
            Console.Write($"{x} ");
        }
        Console.Write("\n");
    }

}

int n = ReadNumber();
int m = ReadNumber();

double[,] matrix = GenerateMatrix(n, m);

PrintMatrix(matrix);