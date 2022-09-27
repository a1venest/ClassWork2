Console.WriteLine("Введите X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0&&y>0)
{
    Console.WriteLine("I четверть");
}
if (x>0&&y<0)
{
    Console.WriteLine("IV четверть");
}
if (x<0&&y<0)
{
    Console.WriteLine("III четверть");
}
if (x<0&&y>0)
{
    Console.WriteLine("II четверть");
}