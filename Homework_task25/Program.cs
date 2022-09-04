// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.Clear();

  Console.Write("Введите число A: ");
  int A = int.Parse(Console.ReadLine());
  Console.Write("Введите число B: ");
  int B = int.Parse(Console.ReadLine());

int C(int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
    return result;
  }
  
 int answer = C(A, B);
  
  Console.WriteLine(answer);
  