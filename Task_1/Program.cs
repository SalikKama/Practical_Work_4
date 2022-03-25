// Задать массив, заполнить случайными положительными 3х значными числами
// Показать количество нечетных\четных чисел

int CountNechet(int[] arr)
{
    int count = 0;
    int l = arr.Length;
    for (int i = 0; i < l; i++)
    {
        if (arr[i] % 2 != 0)
        {
            count++;
        }
    }
    return count;
}

int CountСhet(int[] arr)
{
    int count = 0;
    int l = arr.Length;
    for (int i = 0; i < l; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = new int[10];
// Заполнение массива
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(100, 1000);
}
// Вывод массива
for (int i = 0; i < 10; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int k = CountNechet(array);
int c = CountСhet(array);
Console.WriteLine("Количество нечетных чисел: " + k);
Console.WriteLine("Количество нчетных чисел: " + c);