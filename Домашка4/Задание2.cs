Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()); 
int counter = Convert.ToString(N).Length;
int a = 0;
int res = 0;
for (int i = 0; i < counter; i++)
   {
     a = N - N % 10;
     res = res + (N - a);
     N = N / 10;
   }
Console.Write("Сумма цифр в числе: " );
Console.Write(res);