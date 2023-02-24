Console.Write("Введите номер задачи: 66 или 68  ");
int taskNumber = Convert.ToInt32(Console.ReadLine());

int ReadInt(string text)
{
    Console.Write(text + "  ");
    return Convert.ToInt32(Console.ReadLine());
}

switch (taskNumber)
{
    case (66):
        // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в
        // промежутке от M до N.
        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30

        int SumNumbers(int m, int n)
        {
            if (n - m + 1 == 0) return 0;
            return SumNumbers(m, n - 1) + n;
        }

        var M = ReadInt("Введите число М");
        var N = ReadInt("Введите число N");
        Console.WriteLine(SumNumbers(M, N) + " - cумма натуральных элементов от M до N");

        break;

    case (68):
        // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
        // Даны два неотрицательных числа m и n.
        // m = 2, n = 3 -> A(m,n) = 9
        // m = 3, n = 2 -> A(m,n) = 29

        int AckermanFunc(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (m > 0 && n == 0) return AckermanFunc(m - 1, 1);
            return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
        }

        var N1 = ReadInt("Введите неотрицательое число m");
        var N2 = ReadInt("Введите неотрицательое число n");
        if (N1 >= 0 && N2 >= 0)
            Console.WriteLine($"A(m,n) = {AckermanFunc(N1, N2)}");
        else
            Console.WriteLine("Введены некорректные числа");
        
        break;

    default:
        Console.WriteLine("Введен некорректный номер задачи");
        break;
}
