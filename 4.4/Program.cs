int[] a = new int[10] { 1, -5, 3, 4, 5, -6, 7, 8, -9, 10 };
int sum = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] >= 0)
    {
        sum += a[i];
    }
}

Console.WriteLine(sum);