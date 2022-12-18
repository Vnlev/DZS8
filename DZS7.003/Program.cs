// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber()
{
    string input = Console.ReadLine();
    int res = Convert.ToInt32(input);
    return res;
}

int Prompt(string message)
{
    Console.Write($"{message} > ");
    string input = Console.ReadLine();
    return Convert.ToInt32(input);
}

int[,] GenerateMatrix(int n, int m)
{
    int[,] matrix = new int[n, m]; 
    Random rnd = new Random();
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            matrix[i, j] = rnd.Next(-100, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[, ] matrix)
{
    for (int i = 0;i  < matrix.GetLength(0); ++i)
    {
        for (int j = 0;j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.Write("\n");
    }
}

int n = Prompt("Введите высоту таблицы");
int m = Prompt("Введите ширину таблицы");

int[,] matrix = GenerateMatrix(n, m);
PrintMatrix(matrix);

for (int c = 0; c < m; ++c)
{
    int sum = 0;
    for (int r = 0; r < n; ++r)
    {
        sum += matrix[r, c];
    }
    double average = (double)sum / n;
    average = Math.Round(average, 2);
    Console.Write($"{average} ");
}
Console.Write("\n");



