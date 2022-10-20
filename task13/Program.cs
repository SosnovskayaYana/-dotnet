// программa выводит третью цифру 
// заданного числа 
// или сообщает, что третьей цифры нет 

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ThirdDigit(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    if (number > 99)
    {
        int thirdDigit = ThirdDigit(number);

        Console.WriteLine($"Третья цифра {number} => {thirdDigit}");
    }
    else
    {
        Console.WriteLine($"У числа {number} нет третьей цифры ");
    }
}
else
    Console.WriteLine("Некорректный ввод. Введите положительное число. ");