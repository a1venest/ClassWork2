Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

void Div(int number)
{
    if (number%7==0&&number%23==0)
    {
        Console.WriteLine("Кратно.");
    }
    else
    {
        Console.WriteLine("Не кратно.");
    }
}

Div(number);
