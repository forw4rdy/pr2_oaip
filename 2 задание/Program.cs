Console.Write("Введите десятичное число: ");
int a = int.Parse(Console.ReadLine());

string b = "";

while (a > 0)
{
    int c = a % 2;

    if (c == 0)
    {
        b = "0" + b;
    }
    else
    {
        b = "1" + b;
    }

    a = a / 2;
}

Console.WriteLine("Двоичное число: " + b);