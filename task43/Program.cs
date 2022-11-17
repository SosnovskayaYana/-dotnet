// программa, найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] CrossLines(double b1, double k1, double b2, double k2)
{
    double[] result = new double[2];
    result[0] = Math.Round((b2 - b1) / (k1 - k2), 2);
    result[1] = Math.Round(k1 * result[0] + b1, 2);
    return result;
}


Console.Write("Введите число: b1 = ");
double ab1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: k1 = ");
double ak1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: b2 = ");
double ab2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: k2 = ");
double ak2 = Convert.ToInt32(Console.ReadLine());

if (ak1 != ak2)
{
    double[] crossLines = CrossLines(ab1, ak1, ab2, ak2);
    Console.WriteLine("Координаты точки пересечения:");
    Console.WriteLine($"x = {crossLines[0]}, y = {crossLines[1]}");
}
else Console.WriteLine("Прямые не пересекаются ");


