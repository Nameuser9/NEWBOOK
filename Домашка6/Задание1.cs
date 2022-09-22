void Fillarray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] =Convert.ToInt32(Console.ReadLine());                    //new Random().Next(-1000, 1001);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    int chislb0 = 0;
    while (position < count)
    {
        
       //Console.WriteLine(col[position] );
        if (col[position] > 0)
        {
          chislb0++;
          position++;
        }
        else
       position++; 
    }
    Console.WriteLine($"чисел положительных всего - {chislb0} ");
    //Console.WriteLine();
}
Console.WriteLine("сколько чисел в массиве");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводите числа массива");
int[] array = new int [n];
Fillarray(array);
PrintArray(array);