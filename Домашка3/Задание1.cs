void Fillarray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());                   //;new Random().Next(1, 10)
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
//Console.WriteLine("сколько чисел в вашем массиве?");
// int n = Convert.ToInt32(Console.Read());
int[] array  = new int [ 5 ];
Fillarray(array);
int i = 0;
if (array[ i ] == array[4-i])
{
    i++;
    if  (array[ i ] == array[4 - i])
    {
        i++;
        Console.WriteLine("число  полиндром");
    }
}
else Console.WriteLine("число не полиндром");
// for (int i =0; array[i] == array[4 - i];i++)
// {
    
//     ;
// }
 PrintArray(array);