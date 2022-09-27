// Console.WriteLine("Введите X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0&&y>0)
// {
//     Console.WriteLine("I четверть");
// }
// if (x>0&&y<0)
// {
//     Console.WriteLine("IV четверть");
// }
// if (x<0&&y<0)
// {
//     Console.WriteLine("III четверть");
// }
// if (x<0&&y>0)
// {
//     Console.WriteLine("II четверть");
// }

double GetNumber(string name)
{
    Console.WriteLine("Введите значение " + name);
    return Convert.ToDouble(Console.ReadLine());
}



int GetNumChetv(double x, double y)
{
    if (x > 0 && y > 0)

        return 1;

    else
    if (x > 0 && y < 0)

        return 4;

    else
    if (x < 0 && y < 0)

        return 3;

    else return 2;

}
double x = GetNumber("x");
double y = GetNumber("y");

Console.WriteLine(GetNumChetv(x, y) + " четверть.");
