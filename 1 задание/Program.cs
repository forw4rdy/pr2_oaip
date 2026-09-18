Console.Write("Введите двоичное число: ");
string a = Console.ReadLine();

int b = 0;

for (int i = 0; i < a.Length; i++)
{
    b = b * 2;

    if (a[i] == '1')
    {
        b = b + 1;
    }
}

Console.WriteLine("Десятичное число: " + b);