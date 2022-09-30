// Задача 27
Console.Write("Введите число положительное: ");
int n = Convert.ToInt32(Console.ReadLine());
int r = 0;

if (n != 0 && n >0 )
{
    string m = Convert.ToString(n);
    for (int i = 0; i <= m.Length-1; i++)
    {
        //r =r + m[i];
        r =r + int.Parse(m[i].ToString());
    
    }
    Console.Write(r);
    
}
else Console.Write("Ноль! или минус!!!");