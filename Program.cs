int sum = 0;
int count = 0;
int maxGrade = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
while (grade != -1)
{
    sum += grade;
    count++;
    if (grade > maxGrade)
    {
        maxGrade = grade;
    }

    grade = int.Parse(Console.ReadLine());
}
if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count}");
    Console.WriteLine($"Наибольшая оценка: {maxGrade}");
}
else
{
    Console.WriteLine("Оценок было выведено");
}