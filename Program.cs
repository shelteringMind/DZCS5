//*/
//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandArray(int size)
{
    int[] array = new int[size];
    for(int i=0;i<size;i++) {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int ParityCount(int[] array)
{
    int count = 0;
    foreach(int elem in array) {
        count += elem % 2==0 ? 1 : 0;
    }
    return count;
}

void zadacha1()
{
    Console.WriteLine("Введите размер массива случайных чисел: ");
    int sizeArray = int.Parse(Console.ReadLine()!);
    int[] ar = new int[sizeArray];
    ar = RandArray(sizeArray);
    Console.WriteLine($"[{String.Join(",", ar)}]");
    Console.Write($"Количество четных элементов в массиве равно: {ParityCount(ar)}");
}

zadacha1();
//*/

/*/
//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

int[] RandArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i=0;i<size;i++) {
        array[i] = new Random().Next(min,max);
    }
    return array;
}

int NotParityIndexSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length ; i++) {
        sum += i % 2 != 0 ? array[i] : 0;
    }
    return sum;
}

void zadacha2()
{
    Console.Write("Введите размер массива случайных чисел: ");
    int sizeArray = int.Parse(Console.ReadLine()!);
    Console.Write("Введите минимальное значение диапазона случайных чисел: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Введите максимальное значение диапазона случайных чисел: ");
    int max = int.Parse(Console.ReadLine()!);
    int[] ar = new int[sizeArray];
    ar = RandArray(sizeArray, min, max);
    Console.WriteLine($"[{String.Join(",", ar)}]");
    Console.Write($"Сумма элементов, стоящих на нечетных индексах в массиве, равна: {NotParityIndexSum(ar)}");
}

zadacha2();
//*/

/*/
//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double[] RandArray(int size, int min, int max)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++) {
        array[i] = (new Random().Next(min,max)) * (new Random().NextDouble());
    }
    return array;
}

double DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach(double elem in array) {
        max = elem >= max ? elem : max;
        min = elem < min ? elem : min;
    }
    return max - min;
}

void zadacha3()
{
    Console.Write("Введите размер массива случайных чисел: ");
    int sizeArray = int.Parse(Console.ReadLine()!);
    Console.Write("Введите минимальное значение диапазона случайных чисел: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Введите максимальное значение диапазона случайных чисел: ");
    int max = int.Parse(Console.ReadLine()!);
    double[] ar = new double[sizeArray];
    ar = RandArray(sizeArray, min, max);
    Console.WriteLine($"[{String.Join(", ", ar)}]");
    Console.Write($"Разница между максимальным и минимальным элементами массива равна: {DiffMaxMin(ar)}");
}

zadacha3();
//*/