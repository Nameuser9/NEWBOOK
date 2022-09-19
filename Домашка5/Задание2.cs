void Fillarray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-1000, 1001);                   //Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
       Console.WriteLine(col[position]);
       position++; 
    }
}
//int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [8];
Fillarray(array);
PrintArray(array);
//for (int i=0; i % 2 < 1; i++);
int i = 0;
int sum = 0;
while (i < 8)

    if (i % 2 > 0)
    //while (i % 2 < 1)
    {
        sum = sum + array[i];
        i++;
    }

    else
{
    i++;
}
Console.WriteLine($"сумма элементов массива с нечётными иднексами равна - {sum}" );
