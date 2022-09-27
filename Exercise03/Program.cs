double GetNumber(string name)
{
    Console.WriteLine("Введите " + name);
    return Convert.ToDouble(Console.ReadLine());
}
double CoordinatPoint(double x1, double y1, double x2, double y2)
{
    double CP1(double x1, double y1)
    {
        return Math.Pow((x1 + y1), 2);
    }

    double CP2(double x2, double y2)
    {
        return Math.Pow((x2 + y2), 2);
    }

    return Math.Sqrt((CP1(x1,y1)) + (CP2(x2,y2)));
}
double x1 = GetNumber("x1");
double y1 = GetNumber("y1");
double x2 = GetNumber("x2");
double y2 = GetNumber("y2");

Console.WriteLine("Координаты точки: " + CoordinatPoint(x1, y1, x2, y2));