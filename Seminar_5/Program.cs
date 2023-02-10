Console.WriteLine("Введите номер задачи: 34, 36 или 38");
int task_number = Convert.ToInt32(Console.ReadLine());

// Функция заполнения массива случайными числами
int[] GetArrayRand(int dim, int left_lim, int right_lim)
{
    int[] arr_rand = new int[dim];
    Random rand = new Random();

    for (int i = 0; i < dim; i++)
        arr_rand[i] = rand.Next(left_lim, right_lim + 1);

    return arr_rand;
}

// Функция вывода массива в консоль
void PrintArray(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

switch (task_number)
{
    case (34):
        // Задайте массив заполненный случайными положительными трёхзначными числами. 
        // Напишите программу, которая покажет количество чётных чисел в массиве.
        // [345, 897, 568, 234] -> 2

        // Функция вычисления количества четных чисел в массиве
        void GetNumEven(int[] array, out int result)
        {
            result = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                    result++;
        }

        int[] array34 = GetArrayRand(4, 100, 999);
        PrintArray(array34);
        GetNumEven(array34, out int result);
        Console.WriteLine(result);

        break;

    case (36):
        // Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, 
        // стоящих на нечётных позициях.
        // [3, 7, 23, 12] -> 19
        // [-4, -6, 89, 6]-> 0

        // Функция нахождения суммы элементов, стоящих на нечётных позициях
        void GetSumNumOdd(int[] array, out int sum)
        {
            sum = 0;
            for (int i = 1; i < array.Length; i++)
                if (i % 2 != 0)
                    sum += array[i];
        }

        int[] array36 = GetArrayRand(4, 0, 10);
        PrintArray(array36);
        GetSumNumOdd(array36, out int sum);
        Console.WriteLine(sum);

        break;

    case (38):
        // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
        // элементов массива.
        // [3 7 22 2 78] -> 76

        // Функция заполнения массива случайными вещественными числами
        double[] GetArrayRandTask38(int dim38, double left_lim38, double right_lim38)
        {
            double[] arr_rand38 = new double[dim38];
            Random rand = new Random();

            for (int i = 0; i < dim38; i++)
                arr_rand38[i] = Math.Round(left_lim38 + (right_lim38 - left_lim38) * rand.NextDouble(), 1);

            return arr_rand38;
        }

        // Функция вывода массива в консоль
        void PrintArrayTask38(double[] arr38)
        {
            Console.WriteLine("[" + string.Join(", ", arr38) + "]");
        }

        // Функция нахождения максимального и минимального элементов массива
        void GetMinMaxNum(double[] array38, out double max_num, out double min_num)
        {
            if (array38[0] >= array38[1])
            {
                max_num = array38[0];
                min_num = array38[1];
            }
            else
            {
                max_num = array38[1];
                min_num = array38[0];
            }

            for (int i = 2; i < array38.Length; i++)
            {
                if (max_num < array38[i])
                    max_num = array38[i];

                if (min_num > array38[i])
                    min_num = array38[i];
            }
        }

        double[] array38 = GetArrayRandTask38(4, 1.2, 10.3);
        PrintArrayTask38(array38);
        GetMinMaxNum(array38, out double max_num, out double min_num);
        Console.WriteLine(max_num - min_num);

        break;

    default:
        break;
}
