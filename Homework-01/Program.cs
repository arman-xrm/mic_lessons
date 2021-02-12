using System;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert count of Array:");
            Console.Write("Count = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("===From Automat press 0 === From manual press 1===");
            int g = int.Parse(Console.ReadLine());
            int[] arr = arr = GetArrayAutomat(n); ;
            if (g == 0){
                arr = GetArrayAutomat(n);

            }else if (g == 1){
                arr = GetArrayManual(n);
            }else{
                Console.WriteLine("=====================Read attentively====================");
            }

Console.WriteLine("=================My Array======================");
PrintArray(arr);

Console.WriteLine("==================Sum of Array========================");
Console.WriteLine(GetSumArrayElements(arr));

Console.WriteLine("==================Max Element of Array========================");
Console.WriteLine(GetMaxElement(arr));

Console.WriteLine("==================Max Element of Array====================");
Console.WriteLine(GetMinElement(arr));

//int[] arrPrime = GetPrimeArray(arr);
//Console.WriteLine("==================Prime Array========================");
//PrintArray(arrPrime);

PrintArray(SortArray(arr));

        }
        private static int[] SortArray(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

private static int GetMinElement(int[] arr)
{
    int min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    return min;
}

private static int[] GetPrimeArray(int[] arr)
{
    throw new NotImplementedException();
}

private static int GetMaxElement(int[] arr)
{
    int max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}

private static int GetSumArrayElements(int[] arr)
{
    int sum = default;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum;
}

private static void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"arr[{i}] = {arr[i]}");
        //Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
    }
}

private static int[] GetArrayAutomat(int n)
{
    int[] arr = new int[n];
    //Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(-20, 50);//.rnd.Next(-20, 50);            
    }

    return arr;
}

private static int[] GetArrayManual(int n)
{
    int[] arr = new int[n];


    for (int i = 0; i < n; i++)
    {
        Console.Write($"arr[{i}] = ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    return arr;
}
    }
}
