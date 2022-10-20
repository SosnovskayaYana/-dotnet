// программa, принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// double d = 5.099997545;
// double res = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(res);

// Math.Sqrt(45);


Console.WriteLine("Введите координаты точек: ");

Console.Write("ax: ");
int ax = Convert.ToInt32(Console.ReadLine());

Console.Write("ay: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.Write("bx: ");
int bx = Convert.ToInt32(Console.ReadLine());

Console.Write("by: ");
int by = Convert.ToInt32(Console.ReadLine());

int k1 = ax - bx;
int k2 = ay - by;

double distance = Math.Sqrt(k1 * k1 + k2 * k2);

Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));




/*      Решение помощью метода

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int x21, int y21)
{
    int rangeX = x11 - x21;
    int rangeY = y11 - y21;
    double rangeZ = Math.Sqrt(rangeX * rangeX + rangeY * rangeY);
    return rangeZ;
}

double result = Range(x1,y1,x2,y2);
Console.Write($"А ({x1},{y1}); B ({x2},{y2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");
  */