// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
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

int[] GenerateArray(int length) 
{
    int[] result = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100,1000 );

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

(int EvenCounter, bool IsEvens) EvenElementCount(int[] array)
{
    int EvenCounter = 0;
    bool IsEvens=false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0 ) EvenCounter++;
    }
    if (EvenCounter!=0) IsEvens=true;
    return (EvenCounter, IsEvens);
}

int Size = InputInt32("Enter size of array");
int[] RandomArray = GenerateArray(Size);
var (EvenCounter, YesEvens) = EvenElementCount(RandomArray);
PrintArray(RandomArray);
if (YesEvens) System.Console.WriteLine($"Generated array contains {EvenCounter} even elements");
else System.Console.WriteLine("No even elemets");
