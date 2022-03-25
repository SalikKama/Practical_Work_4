// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] arr)
{
    int l = arr.Length;
    for (int i = 0; i < l; i++)
    {
        arr[i] = new Random().Next(0, 500);
    }
}

void PrintArray(int[] arr)
{
    int l = arr.Length;
    for (int i = 0; i < l; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int CountNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100) count++;
    }
    return count;
}

int[] array = new int[123];

FillArray(array);
PrintArray(array);
int k = CountNumbers(array);
Console.WriteLine("Количество 2-х значных чисел: " + k);