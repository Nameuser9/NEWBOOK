Console.Write("Введите 2 числа ");                  //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int a1 = a;
int i = 1;
// if (b == 0)
// {
//     a = 1;
// }
// else
{ 
    while (i < b)
    {
            a = a*a1;                //a*a*a*a*a*a*a*a*a*
            i++;
    }
}
Console.Write("Число а в степени в ");
Console.Write(a);

