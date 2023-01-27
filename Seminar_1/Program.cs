Console.WriteLine("Введите номер задачи: 2, 4, 6 или 8");
int task_number = Convert.ToInt32(Console.ReadLine());

int number1, number2, number3;

switch (task_number)
{
    case 2:
        // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        // a = 5; b = 7 -> max = 7
        // a = 2 b = 10 -> max = 10
        // a = -9 b = -3 -> max = -3

        Console.Write("Введите первое число  ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число  ");
        number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2)
        {
            Console.WriteLine(number1 + " - большее число, " + number2 + " - меньшее число");
        }
        else if (number1 < number2)
        {
            Console.WriteLine(number2 + " - большее число, " + number1 + " - меньшее число");
        }
        else if (number1 == number2)
        {
            Console.WriteLine("Введенные числа равны");
        }
        break;

    case 4:
        // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        // 2, 3, 7 -> 7
        // 44 5 78 -> 78
        // 22 3 9 -> 22

        Console.Write("Введите первое число  ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число  ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число  ");
        number3 = Convert.ToInt32(Console.ReadLine());

        int max = number1;

        if (max < number2)
        {
            max = number2;
        }

        if (max < number3)
        {
            max = number3;
        }

        Console.WriteLine(max + " - максимальное число");
        break;

    case 6:
        //  Задача 6: Напишите программу, которая на вход принимает число 
        //  и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        //  4 -> да
        //  -3 -> нет
        //  7 -> нет

        Console.Write("Введите число  ");
        number1 = Convert.ToInt32(Console.ReadLine());

        if (number1 % 2 == 0)
        {
            Console.WriteLine(number1 + " - четное число");
        }
        else
        {
            Console.WriteLine(number1 + " - нечетное число");
        }

        break;

    case 8:
        // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
        // все чётные числа от 1 до N.
        // 5 -> 2, 4
        // 8 -> 2, 4, 6, 8

        Console.Write("Введите число  ");
        number1 = Convert.ToInt32(Console.ReadLine());

        if (number1 <= 1)
        {
            Console.Write("Введено неккоректное число. Число должно быть больше 1");
        }
        else
        {
            for (int i = 1; i < number1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        break;

    default:
        Console.WriteLine("Введен неккоректный номер задачи");
        break;
}