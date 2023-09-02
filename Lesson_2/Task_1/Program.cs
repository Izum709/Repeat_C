// Функции/Методы
Console.WriteLine("Hello, Function");
double Function(double x)
{
    double result = x * x; 
    return result;
}
Console.Write("add number N ->  ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Function(n));