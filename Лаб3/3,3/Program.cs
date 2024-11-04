Console.WriteLine("--- Введіть число ---");
int a = Convert.ToInt32(Console.ReadLine());
int c;
for (int b = 1; b <= 10; b++)
{
    c = a * b;
    Console.WriteLine($" {a} * {b} = {c} ");
}
