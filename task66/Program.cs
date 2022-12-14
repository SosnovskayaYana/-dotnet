/* Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

int SumNatureNumbers(int numberA, int numberB)
{
    // int sum = 0;
    if (numberA > numberB) return 0;
    return SumNatureNumbers(numberA, numberB - 1) + numberB;
}

Console.Write("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());


if (m < n)
{
    int result = SumNatureNumbers(m, n);
    Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n}  = {result}");
}

if (m > n)
{
    int result = SumNatureNumbers(n, m);
    Console.Write($"Сумма натуральных элементов в промежутке от {n} до {m}  = {result}");
}

if (m == n)
{
    Console.Write($"Некорректный ввод");
}