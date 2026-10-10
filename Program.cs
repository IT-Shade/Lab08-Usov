string answer;

do {
    Console.Write("Введите дату посещения (например, 01.09): ");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");
    
    Console.Write("Добавить ещё одну запись? (да/нет): ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранён");

int count = 0;
string name;

Console.WriteLine("Введите имена учеников, для завершения введите конец");

do
{
    name = Console.ReadLine();
if (name != "конец");
    {
        count++;
    }
} while (name != "конец");
Console.WriteLine($"Количество введённых имён: {count}");

int totalPages = 0;
int pagesPerDay;

Console.WriteLine("Введите количество страниц, прочитанных за день, для завершения введите 0:");

do
{
    Console.Write("Страниц за день: ");
    pagesPerDay = Convert.ToInt32(Console.ReadLine());
    if (pagesPerDay != 0);
    totalPages += pagesPerDay;

} while (pagesPerDay != 0);

Console.WriteLine($"Количество прочитанных страниц: {totalPages}");