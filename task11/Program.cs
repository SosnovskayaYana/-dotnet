// программa, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число отрезка 100-999 => {number} ");

int DelDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int digit = firstDigit * 10 + secondDigit;
    return digit;
}

int digitDel = DelDigit(number);
Console.WriteLine($"Искомое число => {digitDel} ");