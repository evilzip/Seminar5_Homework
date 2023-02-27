// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int InputInt32(string message)
{
    System.Console.Write(($"{message} "));
    int value;
    bool isCorrectInt32 = int.TryParse(Console.ReadLine(), out value);
    if (isCorrectInt32)
    {
        return value;
    }
    System.Console.WriteLine("You enetrd not a number");
    Environment.Exit(-1);
    return 0;
}


int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array)
{
    System.Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine(']');
}

int SumElemntAtOddPosition (int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        Sum = Sum + array[i];
    }
    return Sum;
}

int Size = InputInt32("Eneter size of array");
int MinLimit = InputInt32("Enetr minimal element");
int MaxLimit = InputInt32("Enetr minimal element");
int[] RandomArray = GenerateArray(Size, MinLimit, MaxLimit);
PrintArray(RandomArray);
System.Console.WriteLine(SumElemntAtOddPosition(RandomArray));
