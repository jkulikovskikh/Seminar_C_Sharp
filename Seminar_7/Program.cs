Console.Write("Введите номер задачи: 47, 50, 52  ");
int taskNumber = Convert.ToInt32(Console.ReadLine());

int ReadInt(string text)
{
    Console.Write(text + "  ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrixInt(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }

    return matrix;
}

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

switch (taskNumber)
{
    case (47):
        // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        // m = 3, n = 4.
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9

        double[,] GetMatrixDouble(int row, int col)
        {
            double[,] matrix = new double[row, col];
            Random rand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round(rand.Next(-10, 11) + rand.NextDouble(), 1);
                }

            return matrix;
        }

        void PrintMatrixDouble(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        var matrix47 = GetMatrixDouble( ReadInt("Введите количество строк матрицы"),
            ReadInt("Введите количество столбцов матрицы"));
        PrintMatrixDouble(matrix47);

        break;

    case (50):
        // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
        // и возвращает значение этого элемента или же указание, что такого элемента нет.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет

        void FindNumber(int[,] matrix, int iRow, int iCol)
        {
            if (iRow < matrix.GetLength(0) && iCol < matrix.GetLength(1))
                Console.Write($"({iRow},{iCol}) -> {matrix[iRow, iCol]}");
            else
                Console.Write($"({iRow},{iCol}) -> такого числа в массиве нет");
        }

        var matrix50 = GetMatrixInt(ReadInt("Введите количество строк матрицы"), 
            ReadInt("Введите количество столбцов матрицы"));
        PrintMatrixInt(matrix50);
        FindNumber(matrix50, ReadInt("Введите номер строки от 0 до N"),
            ReadInt("Введите номер столбца от 0 до N"));

        break;

    case (52):
        // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

        void FindMeanInColumn(int[,] matrix)
        {
            int sum;
            Console.Write("Среднее арифметическое каждого столбца: ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                    sum += matrix[i, j];

                Console.Write(Math.Round((double)sum / matrix.GetLength(0), 1));

                if (j < matrix.GetLength(1) - 1)
                    Console.Write("; ");
                else
                    Console.Write(".");
            }
        }

        var matrix52 = GetMatrixInt(ReadInt("Введите количество строк матрицы"), 
            ReadInt("Введите количество столбцов матрицы"));
        PrintMatrixInt(matrix52);
        FindMeanInColumn(matrix52);

        break;

    default:
        Console.WriteLine("Номер задачи введен некорректно");
        break;
}