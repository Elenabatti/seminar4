// Напишите программу, которвая принимает на вход число и выдаёт количество цифр в числе
 //Console.Clear();
 //Console.WriteLine("input A: ");
 //int A =int.Parse(Console.ReadLine());
 //Console.WriteLine();
 //string a = Convert.ToString(A);
 //Console.WriteLine(a.Length);

Console.Clear();
Console.WriteLine("input A: ");
int A =int.Parse(Console.ReadLine());
int count = 0;
while (A>=1)
{
    count++;
    A= A/10;
}
Console.WriteLine(count);