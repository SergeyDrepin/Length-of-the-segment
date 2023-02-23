// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = 7;
int y1 = -5;
int z1 = 0;

int x2 = 1;
int y2 = -1;
int z2 = 9;

int a = x1 - x2;
int b = y1 - y2;
int c = z1 - z2;

double length = Math.Sqrt(a*a + b*b + c*c);

Console.WriteLine(length);
