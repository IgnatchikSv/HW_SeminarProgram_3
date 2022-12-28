// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int getUserValue(string message)
{
  Console.WriteLine(message);
  int result = int.Parse(Console.ReadLine());
  return result;
}
double getDistanceBetweenPoints (int Ax,int Ay,int Az,int Bx,int By,int Bz)
{
  double result = Math.Sqrt(Math.Pow((Ax-Bx),2) + Math.Pow((Ay-By),2) + Math.Pow((Az-Bz),2));
  return result;
}

int Ax = getUserValue($"Введите x для первой точки: ");
int Ay = getUserValue($"Введите y для первой точки: ");
int Az = getUserValue($"Введите z для первой точки: ");

int Bx = getUserValue($"Введите x для второй точки: ");
int By = getUserValue($"Введите y для второй точки: ");
int Bz = getUserValue($"Введите z для второй точки: ");

double distance = getDistanceBetweenPoints(Ax,Ay,Az,Bx,By,Bz);
Console.WriteLine($"Расстояние между точками равно {Math.Round(distance,2)}");