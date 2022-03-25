// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillArray(int[] arr)
{
    int l = arr.Length;
    for (int i = 0; i < l; i++)
    {
        arr[i] = new Random().Next(0, 100);
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

int SumNechetPos(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] array = new int[20];
FillArray(array);
PrintArray(array);
int S = SumNechetPos(array);
Console.WriteLine(S);