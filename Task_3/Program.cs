
/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. 6 -> да, 7 -> да, 1 -> нет.
*/

// назначение функции
void WeekendDayDigit()
{
    // получение данных от пользователя:
    Console.WriteLine("Введите число от 1 до 7: ");
    int number = int.Parse(Console.ReadLine());

    // проверка условия и вывод ответа пользователю:
    if (number > 7 || number < 0)
    {
        Console.WriteLine("Такого дня недели не существует");
    }
    else if (number < 6)
        {
            Console.WriteLine("Рабочий день");
        }
        else 
        {
            Console.WriteLine("Выходной день");
        }
}

// вызов функции
WeekendDayDigit();
