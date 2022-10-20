// программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).



Console.WriteLine("Введите номер четверти");
int loc = Convert.ToInt32(Console.ReadLine());


string Quarter(int x)
{
    if (x == 1) return "x > 0 и y > 0";
    if (x == 2) return "x > 0 и y < 0";
    if (x == 3) return "x > 0 и y > 0";
    if (x == 4) return "x < 0 и y > 0";
    return "Введены некоректные данные. ";
}

string quarter = Quarter(loc);
Console.Write($"Диапазон координат для четверти {loc}:  ");
Console.WriteLine(quarter);
