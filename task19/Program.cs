// программa, принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


bool TurnDigit(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 / 10; ;
    int num5 = num % 10;

    if (num1 == num5 && num2 == num4) return true;
    return false;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    bool turn = TurnDigit(number);
    if (turn)
    {
        Console.WriteLine("ДА ");
    }
    else
        Console.WriteLine("НЕТ ");
}
else
    Console.Write("Некорректный вод данных. ");


// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int n = num % 100 / 10;   // выводит 4
// Console.Write($"{n}");      