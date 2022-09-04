//Напишите программу, которая принимает на вход число и выдаёт сумму чисел в числе

Console.Clear();
Console.WriteLine("Input i: ");
int i = int.Parse(Console.ReadLine());
int sum =0;
while (i>0)
{
    sum += i%10;
     i = i/10;
    
} 
Console.WriteLine(sum);

