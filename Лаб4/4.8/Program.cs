Console.WriteLine("--- Введіть який стовбець матриці порахувати ---");
int n = Convert.ToInt32(Console.ReadLine());

int[,] a = {
    {4 ,5, 6,},
    {5 ,3, -2,},
    {7, 1, 0,},
};
int sum = 1;
n--;
for (int i = 1; i < 3; i++)
{
    sum *= a[i, n];
    n++;
}
Console.WriteLine($"Добуток елементів стовпця {n + 1} = {sum}");



