// Задача №29
int[] a = new int[8];

for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(0, 100);
}
Console.Write("[" + string.Join(", ", a ) + "]");
