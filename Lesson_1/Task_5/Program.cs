// Генератор случайных чисел и double
double a = new Random().Next(1, 10);
double b = new Random().Next(1, 10);
double c = 0;
if (a > b)
{
    c = a / b;
}
if (a < b)
{
    c = b / a;
}
Console.WriteLine(c);
Console.WriteLine(a);
Console.WriteLine(b);