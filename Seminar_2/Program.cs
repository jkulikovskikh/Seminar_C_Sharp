Console.Write("Введите номер задачи: 10, 13 или 15  ");
int task_number = Convert.ToInt32(Console.ReadLine());

int number;

switch (task_number)
{
    case 10:
        // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
        // на выходе показывает вторую цифру этого числа.
        // 456 -> 5
        // 782 -> 8
        // 918 -> 1

        Console.Write("Введите трёхзначное число  ");
        number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        if (number > 99 && number < 1000)
        {
            number = number / 10;
            Console.WriteLine("Вторая цифра это числа:  " + number % 10);
        }
        else
        {
            Console.WriteLine("Введено не трехзначное число");
        }

        break;

    case 13:
        // Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
        // или сообщает, что третьей цифры нет.
        // 645 -> 5
        // 78 -> третьей цифры нет
        // 32679 -> 6

        Console.Write("Введите число  ");
        number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        if (number < 100)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
        {
            while (number > 999)
            {
                number /= 10;
            }
            Console.WriteLine("Третья цифра это числа:  " + number % 10);
        }
        break;

    case 15:
        // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
        // и проверяет, является ли этот день выходным.
        // 6 -> да
        // 7 -> да
        // 1 -> нет

        Console.Write("Введите цифру от 1 до 7  ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0 || number > 7)
        {
            Console.Write("Введена некорректная цифра");
        }
        else
        {
            if (number == 6 || number == 7)
            {
                Console.Write("Выходной");
            }
            else
            {
                Console.Write("Не выходной");
            }
        }
        break;

    default:
        Console.Write("Введен некорректный номер задачи");
        break;
}





