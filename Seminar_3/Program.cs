Console.WriteLine("Введите номер задачи 19, 21 или 23");
int task_number = Convert.ToInt32(Console.ReadLine());

int n;

switch (task_number)
{
    case 19:
        // Задача 19
        // Напишите программу, которая принимает на вход пятизначное число и проверяет, 
        // является ли оно палиндромом.
        // 14212 -> нет
        // 12821 -> да
        // 23432 -> да

        Console.WriteLine("Введите пятизначное число");
        n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        if (n >= 10000 && n < 100000)
        {
            int n1 = n / 10000;
            int n2 = (n % 10000) / 1000;
            int n4 = (n % 100) / 10;
            int n5 = n % 10;

            if (n1 == n5 && n2 == n4)
                Console.WriteLine("Число является палиндромом");
            else
                Console.WriteLine("Число не является палиндромом");
        }
        else
        {
            Console.WriteLine("Введено не пятизначное число");
        }
        break;

    case 21:
        // Задача 21
        // Напишите программу, которая принимает на вход координаты двух точек и
        // находит расстояние между ними в 3D пространстве.
        // A (3,6,8); B (2,1,-7), -> 15.84
        // A (7,-5, 0); B (1,-1,9) -> 11.53

        int[] A = new int[3];
        int[] B = new int[3];

        Console.WriteLine("Введите координаты первой точки (x,y,z)");
        A[0] = Convert.ToInt32(Console.ReadLine());
        A[1] = Convert.ToInt32(Console.ReadLine());
        A[2] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки (x,y,z)");
        B[0] = Convert.ToInt32(Console.ReadLine());
        B[1] = Convert.ToInt32(Console.ReadLine());
        B[2] = Convert.ToInt32(Console.ReadLine());

        double distance = 0;

        for (int i = 0; i < 3; i++)
            distance += Math.Pow((A[i] - B[i]), 2);

        distance = Math.Round(Math.Sqrt(distance), 2);

        Console.WriteLine(distance + " - расстояние между двумя точками");
        break;

    case 23:
        // Задача 23
        // Напишите программу, которая принимает на вход число (N) и выдаёт 
        // таблицу кубов чисел от 1 до N.
        // 3 -> 1, 8, 27
        // 5 -> 1, 8, 27, 64, 125

        Console.WriteLine("Введите число");
        n = Convert.ToInt32(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("Введено неккоректное число");
        }
        else
        {
            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(Math.Pow(i, 3) + "  ");
            }
        }
        break;

    default:
        Console.WriteLine("Введен некоректный номер задачи");
        break;
}
