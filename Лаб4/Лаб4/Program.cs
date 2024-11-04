int[] a = new int[5] { 1, 6, 5, 7, 2 };
int sum = 0;

for (int i = 0; i < a.Length; i++)
    sum += a[i];

double average = (double)sum / a.Length;
Console.WriteLine("Cереднє арифметичне: " + average);