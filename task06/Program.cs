// программа, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Программа определит, является ли число четным. ");
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());


if ((number % 2) == 0)
    {
    Console.Write($"{number} четное число"); 
    }
else
    Console.Write($"{number} нечетное число");