Console.WriteLine("Введите номер задачи 25, 27 или 29");
int task_number = Convert.ToInt32(Console.ReadLine());

switch (task_number)
{
    case 25:
        // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
        // возводит число A в натуральную степень B.
        // 3, 5 -> 243 (3⁵)
        // 2, 4 -> 16

        // Функция считывания числа с консоли
        int GetNumTask25(string text)
        {
            return Convert.ToInt32(text);
        }

        // Функция возведения числа N1 в степень N2
        int CalcPowN1N2(int n1, int n2)
        {
            int result = 1;
            for (int i = 1; i < n2 + 1; i++)
            {
                result *= n1;
            }

            return result;
        }

        // Функция вывода результата решения задачи в консоль
        void PrintTask25(int n1, int n2)
        {
            Console.WriteLine("А в степени В равно  " + CalcPowN1N2(n1, n2));
        }

        Console.Write("Введите число А  ");
        string? strA = Convert.ToString(Console.ReadLine());

        Console.Write("Введите число B  ");
        string? strB = Convert.ToString(Console.ReadLine());

        if ((int.TryParse(strA, out int numberA)) && (int.TryParse(strB, out int numberB)))
        {
            int a = GetNumTask25(strA);
            int b = GetNumTask25(strB);
            PrintTask25(a, b);
        }
        else
            Console.WriteLine("Неккоректно введено одно из чисел или оба числа");

        break;

    case 27:
        // Задача 27: Напишите программу, которая принимает на вход число и 
        // выдаёт сумму цифр в числе.
        // 452 -> 11
        // 82 -> 10
        // 9012 -> 12

        // Функция считывания числа с консоли
        int[] GetNumTask27(string text)
        {
            int[] n = new int[text!.Length];
            for (int i = 0; i < text!.Length; i++)
            {
                n[i] = Convert.ToInt32(Convert.ToString(text[i]));
            }

            return n;
        }

        // Функция вычисления суммы цифр числа
        int CalcSumNumber(int[] mas)
        {
            int result = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                result += mas[i];
            }

            return result;
        }

        // Функция вывода результата решения задачи в консоль
        void PrintTask27(int sum)
        {
            Console.WriteLine("Сумма цифр в числе  " + sum);
        }

        Console.Write("Введите число  ");
        string? str = Convert.ToString(Console.ReadLine());

        if (!int.TryParse(str, out int number))
            Console.WriteLine("Неккоректно введено число");
        else
        {
            int[] s = GetNumTask27(str);
            PrintTask27(CalcSumNumber(s));
        }

        break;

    case 29:
        // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
        // 6, 1, 33 -> [6, 1, 33]

        // Функция заполнения массива случайными числами
        int[] GetArrayRand(int dim, int left_lim, int right_lim)
        {
            int[] arr_rand = new int[dim];
            Random rand = new Random();

            for (int i = 0; i < dim; i++)
                arr_rand[i] = rand.Next(left_lim, right_lim + 1);

            return arr_rand;
        }

        // Функция вывода результата решения задачи в консоль
        void PrintTask29(int[] a)
        {
            Console.WriteLine("[" + string.Join(", ", a) + "]");
        }

        int[] array = GetArrayRand(12, 10, 101);
        PrintTask29(array);
        
        break;

    default:
        break;
}