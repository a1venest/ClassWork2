//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

void PowN(int N)
{
    int i = 1;
    while (i <= N)
    {
        Console.WriteLine(Math.Pow(i, 2));
        i++;
    }
}

PowN(N);