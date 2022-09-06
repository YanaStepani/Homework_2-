/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5, 78 -> третьей цифры нет, 32679 -> 6
*/

// назначение функции:
void FindThirdDigit()
{
    // получение данных от пользователя
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());

    // преобразование числа в положительное:
    int numberAbs = Math.Abs(number);

    // проверка условия:
    if (numberAbs < 100)
    {
        Console.WriteLine($"В числе {number} третьей цифры нет.");
    }
        else
        {
            //int digit3 = numberAbs % 100;
            while (numberAbs > 1000)
            {
            numberAbs = numberAbs / 10;
            }
            numberAbs = numberAbs % 10;
            System.Console.WriteLine($"Третья цифра из числа {number} = {numberAbs}.");
        }   
}   

// вывод функции:
FindThirdDigit();
