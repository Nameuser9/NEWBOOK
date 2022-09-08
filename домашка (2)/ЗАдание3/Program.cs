Console.WriteLine("введите число, обозначающее день недели от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 5)
{
    Console.WriteLine("Будний день");
}
else 
{
    Console.WriteLine("Выходной день");
}