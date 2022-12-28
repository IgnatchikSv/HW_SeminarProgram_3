// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 

Console.Clear();

int getUserValue(string message)
{
  Console.WriteLine(message);
  int result = int.Parse(Console.ReadLine());
  return result;
}

void displaySqrtTable(int number)

{
for (int index = 1; index < number +1; index++)
 {
 int result =  index*index*index;
 if (index<number)
  {
  Console.Write($"{result},");
  }  
else 
  {
  Console.Write($"{result}.");
  }
  }

}
 
int number = getUserValue ($"Введите число");
displaySqrtTable(number);