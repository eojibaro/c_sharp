int[] RandomIntArray(int arLen, int min = 0, int max = 100) {
    int[] result = new int[arLen];
    Random random = new Random();
    string str = "[";
    for (int i = 0; i < arLen; i++) {
        result[i] = random.Next(min, max + 1);
        str += result[i];
        if (i != arLen - 1) str += ", ";
    }
    str += "]";
    Console.WriteLine("Сгенерированный массив: " + str);
    return result;
}

double[] RandomDoubleArray(int arLen, int min = 0, int max = 100) {
    double[] result = new double[arLen];
    Random random = new Random();
    string str = "[";
    for (int i = 0; i < arLen; i++) {
        result[i] = random.NextDouble() * max + min;
        str += result[i];
        if (i != arLen - 1) str += ", ";
    }
    str += "]";
    Console.WriteLine("Сгенерированный массив: " + str);
    return result;
}

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Ввведите размер массива");
int[] ar1 = RandomIntArray(int.Parse(Console.ReadLine()), 100, 999);

int EvenNumber(int[] ar) {
    int result = 0;
    for (int i = 0; i < ar.Length; i++) {
        if (ar[i] % 2 == 0) result++;
    }
    return result;
}

Console.WriteLine("Кол-во четных числе = " + EvenNumber(ar1));

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Ввведите размер массива");
int[] ar2 = RandomIntArray(int.Parse(Console.ReadLine()));

int OddNumberSum(int[] ar) {
    int result = 0;
    for (int i = 0; i < ar.Length; i++) {
        if (ar[i] % 2 != 0) result += ar[i];
    }
    return result;
}

Console.WriteLine("Сумма нечетных чисел = " + OddNumberSum(ar2));

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Ввведите размер массива");
double[] ar3 = RandomDoubleArray(int.Parse(Console.ReadLine()), 0, 100);

double DiffMinMax(double[] ar) {
    double min = ar[0];
    double max = ar[0];
    for (int i = 1; i < ar.Length; i++) {
        if (ar[i] > max) max = ar[i];
        if (ar[i] < min) min = ar[i];
    }
    return Math.Abs(max - min);
}

Console.WriteLine("Разность (max - min) = " + DiffMinMax(ar3));
