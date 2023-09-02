// Массивы. Поиск числа в массиве и вывод индекса числа
Console.WriteLine("Hello, Array");
int[] array = {12, 42, 36, 42, 56, 26, 4, 78, 39};
// int n = array.Length;
int find = 4;
int index = 0;
while (index < array.Length)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        // break; в случае если искомых чисел в массиве больше чем 1, оператор break прерывает работу
        // программы после первого найденного числа
    }
    index++;
}


