//Задача 19. Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
/*
void Poly (int number1,int i)
{
int k=i/2;
int a=0;
int b=0;
while ( k>0 )
  {
  b = number1 % 10;
  a = number1/ Convert.ToInt32(Math.Pow(10,i-1));
    if (a==b)
    {
    int c= Convert.ToInt32(Math.Pow(10,i-1));
    number1=number1 % c;
    number1=number1 / 10;
    i=i-2;
    k=k-1;
    }
    else
    {
    Console.WriteLine($" это число не палиндром");  
    break;   
    }
      if (k==0)
      Console.WriteLine($" это палиндром");
  }
} 
Console.WriteLine(" Введите,пожалуйста,целое,не отрицательное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i=1;// i- считаем количество знаков в числе.
int number1 = number;
    while (number>9) 
    {
     number/=10;
     i++;
    }
    Poly(number1,i);
*/
//Задача 21 Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 3D пространстве.
/*double Length(double xa, double ya, double za, double xb, double yb, double zb)
{
double l = Math.Round(Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+ Math.Pow((zb-za),2)),2);
  return l;
}
Console.WriteLine("Введите координаты двух точек в трёхмерном пространстве");
Console.Write(" Xa= ");
double xa=Convert.ToDouble(Console.ReadLine());
Console.Write(" Ya= ");
double ya=Convert.ToDouble(Console.ReadLine());
Console.Write(" Za= ");
double za=Convert.ToDouble(Console.ReadLine());
Console.Write(" Xb= ");
double xb=Convert.ToDouble(Console.ReadLine());
Console.Write(" Yb= ");
double yb=Convert.ToDouble(Console.ReadLine());
Console.Write(" Zb= ");
double zb=Convert.ToDouble(Console.ReadLine());
double z = Length(xa,ya,za,xb,yb,zb);
Console.WriteLine($" Расстояние между точками = {z}");
*/

//Задача 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
void Cub (int n)
{
    int z = 1;
while (z<n+1)
{
Console.WriteLine($"~~~~~~~~~~~~~");    
Console.WriteLine($"| {z} | {Math.Pow(z,3)} ");
z++;
}
return;
}
Console.WriteLine ("inpit N: ");
int n = Convert.ToInt32(Console.ReadLine());
Cub(n);


