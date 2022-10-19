// программa, принимает на вход два числа и 
// выводит, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int lostNum = number1 % number2;

if (number1 % number2 == 0)
    Console.WriteLine($"Число {number1} кратно {number2} ");


else
    Console.WriteLine($"Не кратно, остаток {lostNum}");
