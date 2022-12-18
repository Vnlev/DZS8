// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ряд > 1
// Колонка > 7
// 1, 7 -> такого числа в массиве нет

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

int r = Prompt("Введите номер строки"); // r - row ряд
int c = Prompt("Введите номер столбца"); // c - column колонка

// r in [0, n - 1]
// c in [0, m - 1]

if (r < 0 || r >= n || c < 0 || c >= m)
{
    Console.WriteLine("Такого элемента нет :(");
} else
{
    Console.WriteLine(matrix[r, c]);
}

