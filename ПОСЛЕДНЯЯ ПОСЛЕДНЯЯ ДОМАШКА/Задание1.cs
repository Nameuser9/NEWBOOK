Console.WriteLine("Напишите числа сумму чисел между которыми хотите видеть");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int vyvod = 0;
while (n <= m)
{
vyvod += n;
n++;
}
Console.WriteLine(vyvod);