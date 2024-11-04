Console.WriteLine("--- Введіть число ---");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
while (a > 0)
{
    b *= a;
    a--;
    
}
Console.WriteLine(b);