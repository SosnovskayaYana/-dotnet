// цикл, принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите первое число: ");
// double numA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// double numB = Convert.ToInt32(Console.ReadLine());

// double numC = Math.Pow(numA, numB);

// Console.WriteLine($"{numA} в степени {numB} равно {numC} ");


double PowerNumber(double numberA, double numberB)
{
double numberC = Math.Pow(numberA, numberB);
return numberC;
}


Console.Write("Введите первое число: ");
double numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
double numB = Convert.ToInt32(Console.ReadLine());

if (numA != 0 && numB > 0)
{
double powerNumber = PowerNumber (numA, numB);

Console.WriteLine($"{numA} в степени {numB} равно {powerNumber} ");
}

else
Console.WriteLine("Некорректный ввод чисел. ");