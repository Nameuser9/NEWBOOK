﻿void Fillarray2(int[,] collection)
{
    
    //int length = collection.Length;
    //int index = 0;
    for (int chet = 0; chet < collection.GetLength(0); chet++)
    {
        for (int chet2 = 0; chet2 < collection.GetLength(1); chet2++)
        collection[chet,chet2] =new Random().Next(-1000, 1001);                    //;Convert.ToInt32(Console.ReadLine())
    }
}
void PrintArray2(int[,] col)
{
    //int count = col.Length;
    //int position = 0;
   for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
        Console.Write($"{ col [i , j]} ");        
        }
    Console.WriteLine();
    }  
}
Console.WriteLine("сколько должно быть в массве 1:строк, 2 столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
Fillarray2(array);
PrintArray2(array);