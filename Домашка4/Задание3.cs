void Fillarray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
    {
        collection[index] = new Random().Next(1, 10);                   //Convert.ToInt32(Console.ReadLine());
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