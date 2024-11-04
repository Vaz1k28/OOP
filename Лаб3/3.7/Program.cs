Console.WriteLine("--- Введіть число ---");
int a = int.Parse(Console.ReadLine());

int b = 0;
int c = 1;
int sum = 0;
int count = 0;

while (sum + c <= a)
{
    sum += c;
    count++;
    int next = b + c;
    b = c;
    c = next;
}

Console.WriteLine($"Сума чисел Фібоначчі, менша за {a}: {sum}");
Console.WriteLine($"Кількість елементів: {count}");
        