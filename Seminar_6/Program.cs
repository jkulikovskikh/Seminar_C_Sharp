Console.WriteLine("Введите номер задачи: 41 или 43");
int task_number = Convert.ToInt32(Console.ReadLine());

switch (task_number)
{
    case (41):
        // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
        // сколько чисел больше 0 ввёл пользователь.
        // 0, 7, 8, -2, -2 -> 2
        // 1, -7, 567, 89, 223-> 3

        int[] GetArray(string? str)
        {
            Console.WriteLine(str);
            int[] result = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            return result;
        }

        void GetSumPosNum(int[] array, out int sum)
        {
            sum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0)
                    sum++;
        }

        int[] array41 = GetArray("Введите несколько чисел через пробел");
        GetSumPosNum(array41, out int sum);
        Console.Write("Количество чисел больше 0 в массиве равно  " + sum);

        break;

    case (43):
        // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
        // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

        int[] GetNumber(string? str, out bool flag)
        {
            Console.WriteLine(str);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            flag = false;

            if (arr.Length > 4)
                Console.WriteLine("Введено больше 4х чисел");
            else if (arr.Length < 4)
                Console.WriteLine("Введено меньше 4х чисел");
            else if (arr.Length == 4)
                flag = true;

            return arr;
        }

        void PrintResult(double[] coord, int b_1, int k_1, int b_2, int k_2)
        {
            Console.Write("b1 =  " + b_1 + ",");
            Console.Write("  k1 =  " + k_1 + ",");
            Console.Write("  b2 =  " + b_2 + ",");
            Console.Write("  k2 =  " + k_2 + " -> ");
            Console.Write("(" + string.Join(", ", coord) + ")");
        }

        double[] GetResultTask(int b_1, int k_1, int b_2, int k_2)
        {
            double[] result = new double[2];

            result[0] = Math.Round((double)(b_2 - b_1) / (k_1 - k_2), 2);
            result[1] = Math.Round(k_1 * result[0] + b_1, 2);

            Console.WriteLine(result[0]);
            return result;
        }

        int[] array43 = GetNumber("Введите значения для построения двух прямых b1, k1, b2 и k2 через пробел", out bool flag);
        if (flag)
            PrintResult(GetResultTask(array43[0], array43[1], array43[2], array43[3]),
                array43[0], array43[1], array43[2], array43[3]);

        break;

    default:
        break;
}