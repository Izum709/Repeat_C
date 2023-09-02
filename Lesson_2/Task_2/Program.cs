// Функции max 


Console.WriteLine("Hello, Max");
int Max (int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (max < arg2) max = arg2;
    if (max < arg3) max = arg3;
    return max;
}

int a1 = 20;
int b1 = 21;
int c1 = 12;

int a2 = 22;
int b2 = 24;
int c2 = 10;

int a3 = 30;
int b3 = 26;
int c3 = 29;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int maxim = Max(max1, max2, max3);

Console.Write(maxim);