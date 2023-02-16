//ДЗ

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// int[] Array (int size, int minValue, int maxValue)
// {
//     int[] NewArray = new int [size];
//     for (int i =0; i < size; i++)
//     {
//         NewArray [i] = new Random().Next(minValue, maxValue);
//     }
//     return NewArray;
// }

// void PrintArray (int [] NewArray)
// {
//     for(int i = 0; i < NewArray.Length; i++)
//     {
//         Console.Write(NewArray[i] + " ");
//     }
// }

// int NotDouble (int [] NewArray)
// {
//     int result = 0;
//     for(int i = 0; i < NewArray.Length; i++)
//     {
//         if (NewArray[i]%2 == 0)
//         {
//             result++;
//         }
//     }
//     return result;
// }
// Console.WriteLine("введите число элементов в массив:");
// int size = Convert.ToInt32(Console.ReadLine());
// int minValue = 100;
// int maxValue = 1000;
// PrintArray(Array(size, minValue, maxValue));
// Console.WriteLine(" -> " + NotDouble(Array(size, minValue, maxValue)));

//------------------------------------------------------------------------
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
/*
int[] Array (int size)
{
    int[] NewArray = new int [size];
    for (int i =0; i < size; i++)
    {
        Console.Write($"Input element massive {i}:  ");
        NewArray [i] = Convert.ToInt32(Console.ReadLine());
    }
    return NewArray;
}

void PrintArray (int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
        Console.Write(NewArray[i] + " ");
}

int SummaIndex (int [] NouName)
{
    int result = 0;
    for (int i = 1; i < NouName.Length; i+=2)
        result += NouName[i];
    return result;
    
}

Console.WriteLine("Input size massive:");
int size = Convert.ToInt32(Console.ReadLine());
int[] NewArray = Array (size);

PrintArray (NewArray);

Console.WriteLine("");
Console.WriteLine("summa nechetnix index = " + SummaIndex(NewArray));

*/

//------------------------------------------------------------------------
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] Array (int size, int minValue, int maxValue)
// {
//     double[] NewArray = new double [size];
//     for (int i =0; i < size; i++)
//     {
//         NewArray [i] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
//     }
//     return NewArray;
// }
// void PrintArray (double [] NewArray)
// {
//     for(int i = 0; i < NewArray.Length; i++)
//     {
//         Console.Write(NewArray[i] + " ");
//     }
// }

// double NoSummaElement (double [] NewArray)
// {
//     double min = NewArray[0];
//     double max = 0;
//     for (int i = 1; i < NewArray.Length; i++)
//     {
//         if (min > NewArray[i]) min = NewArray[i];
//         else if (max < NewArray[i]) max = NewArray[i];
//     }
//     double result = max - min;
//     return result;
// }

// Console.WriteLine("Input size massive:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min double element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max double element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// double [] nur = Array (size, minValue, maxValue);
// PrintArray(nur);
// double otvet = Math.Round((NoSummaElement(nur)),2);
// Console.WriteLine("no summa -> " + otvet);