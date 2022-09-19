//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void Fillarray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 999);                   //Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if ((col [position]) % 2 < 1)
         { 
            Console.WriteLine(col[position]);
            position++;
         }
         else
            position++;
    }
}
//int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [4];
Fillarray(array);
PrintArray(array);
