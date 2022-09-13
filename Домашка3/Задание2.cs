double method(int x1, int y1,int z1, int x2, int y2, int z2 ) 
{
    double dead;
   dead = ( ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) +((z2 - z1) * (z2 - z1))) ^ (1 / 2);
    return dead;
}


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//только не разобрался с тем, чтобы координаты могли быть дробными, потому что тип double нельзя возводить в степень
//также попрактиковался с методом

Console.WriteLine("Вы хотите узнать расстояние между двумя точками? y-да n-нет");
String choice = Console.ReadLine();

if (choice == "y")
{
Console.WriteLine("Введите координаты точки А");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки b");
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int f =Convert.ToInt32(Console.ReadLine());
//double dist;
//dist = ( (c - a) ^ 2 + (d - b) ^ 2) ^ (1 / 2);
Console.Write("Дистанция от точки А до точки B равна ");
double dist = method( a, b, e,  c, d, f);
Console.Write(dist);
}
else
Console.WriteLine("ну ладно");