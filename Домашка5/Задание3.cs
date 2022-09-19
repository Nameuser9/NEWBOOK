void Fillarray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10001);                   //Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
       Console.WriteLine(col[position]);
       position++; 
    }
}
double[] array = new double [8];
Fillarray(array);
PrintArray(array);
int i = 0;
double sum1 = array[0];
double sum2 = array[0];
while (i < 7)
{
    if (array[i] < sum2)
        {
            sum2 = array[i];
            i++;
        }
    if (array[i] > sum1)
       {
        sum1 = array[i];
        i++;
       }
       else
       i++;
}   

Console.WriteLine($"разность самого большого и маленького числа в массиве равна - {sum1 - sum2}");
Console.WriteLine(sum1);
Console.WriteLine(sum2);