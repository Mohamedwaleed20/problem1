// See https://aka.ms/new-console-template for more information
Console.Write("please enter the num : ");
double num = double.Parse(Console.ReadLine());
if(num > 0)
{
    Console.WriteLine("num is positive");
}
else
{
    Console.WriteLine("num is negative");
}
Console.ReadKey();

