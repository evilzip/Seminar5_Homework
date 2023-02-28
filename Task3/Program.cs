// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

double InputDouble(string message)
{
    System.Console.Write(($"{message} "));
    double value;
    bool isCorrectInt32 = double.TryParse(Console.ReadLine(), out value);
    if (isCorrectInt32)
    {
        return value;
    }
    System.Console.WriteLine("You enetrd not a number");
    Environment.Exit(-2);
    return 0;
}


double[] GenerateArray(int length, double minValue, double maxValue)
{
    double[] result = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = (maxValue - minValue)*rnd.NextDouble() + minValue;
    }
    return result;
}

void PrintArray(double[] array)
{
    System.Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine(']');
}

(double max, double min) FindMinMax (double[] array)
{
    double max=array[0], min=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) max=array[i];       
        if (array[i]<min) min=array[i];
    }
    return (max, min);
}


int Size = InputInt32("Eneter size of array");
double MinLimit = InputDouble("Enetr minimal array range");
double MaxLimit = InputDouble("Enetr maximal aray range");
double[] RandomArray = GenerateArray(Size, MinLimit, MaxLimit);
PrintArray(RandomArray);
(double maximum, double minimum) = FindMinMax(RandomArray);
System.Console.WriteLine($"Difference between MAX ({maximum}) and MIN({minimum}) = {maximum - minimum}");