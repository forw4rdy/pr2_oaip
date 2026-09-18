Console.Write("Введите часы: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Введите минуты: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите время доставки в минутах: ");
int T = int.Parse(Console.ReadLine());

int a = N * 60 + M + T;

int hours = (a / 60) % 24;
int minutes = a % 60;

if (minutes < 10)
{
    Console.Write("0");
}

Console.WriteLine("Время доставки: " + hours + ":" + minutes);