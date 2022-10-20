// программa, принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int SecondDigit(int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}

int secondDigit = SecondDigit(number);


Console.WriteLine($"Вторая цифра {number} => {secondDigit}");
