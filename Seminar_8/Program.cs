Console.Write("Введите номер задачи: 54, 56, 58, 60, 62  ");
int taskNumber = Convert.ToInt32(Console.ReadLine());

int ReadInt(string text)
{
    Console.Write(text + "  ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int row, int col)
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

void PrintMatrix(int[,] matrix)
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
    case (54):
        // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
        // строки двумерного массива.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 7 4 2 1
        // 9 5 3 2
        // 8 4 4 2

        void SortMaxToMin(int[] array)
        {
            int[] arrayNew = new int[array.Length];

            for (int j = 0; j < arrayNew.Length; j++)
                arrayNew[j] = array[j];

            int imax = 0;
            int i = 0;

            while (i < array.Length)
            {
                array[i] = 0;
                for (int j = 0; j < arrayNew.Length; j++)
                {
                    if (array[i] < arrayNew[j])
                    {
                        array[i] = arrayNew[j];
                        imax = j;
                    }
                }
                arrayNew[imax] = -1;
                i++;
            }
        }

        void GetChangeMatrix(int[,] matrix)
        {
            int[] val = new int[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    val[j] = matrix[i, j];

                SortMaxToMin(val);

                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = val[j];
            }
        }

        var matrix54 = GetMatrix(ReadInt("Введите количество строк матрицы"),
            ReadInt("Введите количество столбцов матрицы"));
        PrintMatrix(matrix54);
        Console.WriteLine();
        GetChangeMatrix(matrix54);
        PrintMatrix(matrix54);

        break;

    case (56):
        // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
        // с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
        // 1 строка

        void PrintRowMinSumElements(int[,] matrix)
        {
            int[] sum = new int[matrix.GetLength(0)];
            int min = 0;
            int imin = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum[i] = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sum[i] += matrix[i, j];

                if (i == 0) min = sum[i];
                else
                {
                    if (min > sum[i])
                    {
                        min = sum[i];
                        imin = i;
                    }
                }
            }

            Console.WriteLine(imin + 1 + " - номер строки с наименьшей суммой элементов");
        }

        var matrix56 = GetMatrix(ReadInt("Введите количество строк матрицы"),
            ReadInt("Введите количество столбцов матрицы"));
        PrintMatrix(matrix56);
        PrintRowMinSumElements(matrix56);

        break;

    case (58):
        // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        // Например, даны 2 матрицы:
        // 2 4 | 3 4
        // 3 2 | 3 3
        // Результирующая матрица будет:
        // 18 20
        // 15 18

        int[,] GetMatrixMultiplication(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrixNew = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < matrixNew.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNew.GetLength(1); j++)
                {
                    matrixNew[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                        matrixNew[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
            return matrixNew; 
        }

        var matrix1 = GetMatrix(ReadInt("Введите количество строк 1й матрицы"),
            ReadInt("Введите количество столбцов 1й матрицы"));
        var matrix2 = GetMatrix(ReadInt("Введите количество строк 2й матрицы"),
            ReadInt("Введите количество столбцов 2й матрицы"));
        PrintMatrix(matrix1);
        Console.WriteLine();
        PrintMatrix(matrix2);
        Console.WriteLine();
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            Console.WriteLine("Умножение матриц невозможно, т.к. количество столбцов 1й матрицы не равно количеству строк 2й матрицы");
        else
        {
            var matrix58 = GetMatrixMultiplication(matrix1,matrix2);
            PrintMatrix(matrix58);
        }

        break;

    case (60):
        // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
        // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        // Массив размером 2 x 2 x 2
        // 66(0,0,0) 25(0,1,0)
        // 34(1,0,0) 41(1,1,0)
        // 27(0,0,1) 90(0,1,1)
        // 26(1,0,1) 55(1,1,1)

        void PrintArray(int[,,] array, int[] number)
        {
            int count = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int i = 0; i < array.GetLength(2); i++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        array[i, k, j] = number[count];
                        Console.Write($"{array[i, k, j]}({i},{k},{j})" + "\t");
                        count++;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        int[] GetArrayRand(int iN, int jN, int kN)
        {
            int[] result = new int[iN * jN * kN];
            Random rand = new Random();

            bool flag = true;
            for (int i = 0; i < iN * jN * kN; i++)
            {
                int numRand = rand.Next(10, 99);

                for (int j = 0; j < i + 1; j++)
                {
                    if (result[j] == numRand)
                    {
                        flag = false;
                        i--;
                        break;
                    }
                    flag = true;
                }

                if (flag)
                    result[i] = numRand;
            }

            return result;
        }

        int[,,] array60 = new int[ReadInt("Введите 1ю размерность массива"), ReadInt("Введите 2ю размерность массива"),
        ReadInt("Введите 3ю размерность массива")];
        Console.WriteLine();
        int[] randNumber = GetArrayRand(array60.GetLength(0), array60.GetLength(1), array60.GetLength(2));
        PrintArray(array60, randNumber);

        break;

    case (62):
        // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
        // Например, на выходе получается вот такой массив:
        // 01 02 03 04
        // 12 13 14 05
        // 11 16 15 06
        // 10 09 08 07

        void GetMatrixSpiral(int[,] matrix, int iBegin, int iEnd, int jBegin, int jEnd)
        {
            int k = 0;
            while (k < matrix.GetLength(0) * matrix.GetLength(1))
            {
                for (int j = jBegin; j < jEnd; j++)
                {
                    k++;
                    matrix[iBegin, j] = k;
                }
                iBegin++;

                for (int i = iBegin; i < iEnd; i++)
                {
                    k++;
                    matrix[i, jEnd - 1] = k;
                }
                jEnd--;

                for (int j = jEnd - 1; j >= jBegin; j--)
                {
                    k++;
                    matrix[iEnd - 1, j] = k;
                }
                iEnd--;

                for (int i = iEnd - 1; i >= iBegin; i--)
                {
                    k++;
                    matrix[i, jBegin] = k;
                }
                jBegin++;
            }
        }

        int[,] matrix62 = new int[ReadInt("Введите количество строк матрицы"), ReadInt("Введите количество столбцов матрицы")];
        GetMatrixSpiral(matrix62, 0, matrix62.GetLength(0), 0, matrix62.GetLength(1));
        Console.WriteLine();
        PrintMatrix(matrix62);
        break;

    default:
        break;
}