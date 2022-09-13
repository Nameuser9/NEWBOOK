Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int c = 1;
while (c <= number)
{
    Console.Write($" {Math.Pow(c,3)}");
    c++;
}