Console.WriteLine("--- Введіть число ---");
int a = int.Parse(Console.ReadLine());

string b = "";

while (a > 0)
{
    b = a % 2 + b;
    a /= 2;
}

Console.WriteLine("Двійкове представлення: " + b);