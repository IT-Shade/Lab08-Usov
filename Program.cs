int N = 7;

for (int r = N; r >= 1; r--)
{
    Console.WriteLine(r);
}

Console.WriteLine("Старт!");

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int count = 0;
while (number != 0)
{
    number /= 10;
    count++;
}

Console.WriteLine($"Цифр: {count}");