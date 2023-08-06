// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], 2);
        if (i < arr.Length - 1) Console.Write($"{roundNum}, ");
        else Console.Write($"{roundNum}");
    }
    Console.Write("]");
}

double DifferenceMaxMinDouble(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    double diff = max - min;
    double roundDiff = Math.Round(diff, 2);
    
    double roundMax = Math.Round(max, 2);
    double roundMin = Math.Round(min, 2);

    if (roundMin > 0) Console.Write($" -> {roundMax} - {roundMin} = ");
    else Console.Write($" -> {roundMax} - ({roundMin}) = ");
    return roundDiff;
}

double[] array = CreateArrayRndDouble(5, -99, 100);
PrintArrayDouble(array);

double difference = DifferenceMaxMinDouble(array);
Console.WriteLine(difference);