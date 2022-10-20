// программa, принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int SecondDigit(int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра {number} => {secondDigit}");
}
else
    Console.WriteLine("Некорректный ввод. Введите трехзначное число. ");
