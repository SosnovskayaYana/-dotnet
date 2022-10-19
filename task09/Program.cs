// программа, которая выводит
// случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8



/* int firstDigit = number / 10;     // 78 / 10 = 7
int secondDigit = number % 10;    // 78 % 10 = 8

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа равна {secondDigit}"); */



int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number} ");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} равна {maxDigit} ");