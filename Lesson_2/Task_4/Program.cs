// Массивы, random, методы.
Console.Clear();
Console.WriteLine("Hello, Random!");


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{collection[index]}, ");
        index++;
    }
}

int IndexOf(int[] collection, int find)
{
    int index = 0;
    int indexPosition = -1;
    while (index < collection.Length)
    {
        if (collection[index] == find)
        {
            indexPosition = index;
            break;
        }
        index++;
        
    }
    return index;
}

int[] array = new int[10]; // создание нового массива в котором будет 10 элементов из целочисленных
// элементов [1, 2, 3, 4, 5.....]
// Console.Write("Введите искомое число -> ");
// int find = Convert.ToInt32(Console.ReadLine);
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(IndexOf(array, 6));

