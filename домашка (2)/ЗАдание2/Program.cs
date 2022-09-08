Console.WriteLine("Введите трёх значное число, или же двухзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int n3 = (a % 100) % 10;
if (n3 < 1)
{
    Console.WriteLine("ТРЕТЬЕГО ЧИСЛА НЕТ");
}
else 
{
    Console.Write("Третье число - ");
    Console.Write(n3);
}

