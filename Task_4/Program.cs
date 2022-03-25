// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void FillArray(int[] arr)
{
    int l = arr.Length;
    for (int i = 0; i < l; i++)
    {
        arr[i] = new Random().Next(0, 10);
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

void Multiplication(int[] arr)
{
    int P = 1;
    int l = arr.Length;
    for (int i = 0; i < l / 2; i++)
    {
        P = arr[i] * arr[l - i - 1];
        Console.Write(P + " ");
    }
}

int[] array = new int[11];
FillArray(array);
PrintArray(array);
Console.WriteLine("Произведение пар чисел:");
Multiplication(array);