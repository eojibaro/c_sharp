Random random = new Random();

void Print2DimIntArray(int[,] ar) {
    string str = "[\n";
    for (int i = 0; i < ar.GetLength(0); i++) {
        str += "  [ ";
        for (int j = 0; j < ar.GetLength(1); j++) {
            str += ar[i, j] + ", ";
        }
        str += "],\n";
    }
    str += "]";
    Console.WriteLine(str);
}

void Print2DimDoubleArray(double[,] ar) {
    string str = "[\n";
    for (int i = 0; i < ar.GetLength(0); i++) {
        str += "  [ ";
        for (int j = 0; j < ar.GetLength(1); j++) {
            str += ar[i, j] + ", ";
        }
        str += "],\n";
    }
    str += "]";
    Console.WriteLine(str);
}

int[,] Generate2DimIntArray(int n, int m) {
    int min = 0;
    int max = 100;
    int[,] ar = new int[n, m];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            ar[i, j] = random.Next(min, max);
        }
    }

    return ar;
}

double[,] Generate2DimDoubleArray(int n, int m) {
    int min = 0;
    int max = 100;
    double[,] ar = new double[n, m];
    Random random = new Random();

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            ar[i, j] = random.NextDouble() * max + min;
        }
    }

    return ar;
}

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Задайте кол-во строк и колонок(m, n)");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

// Print2DimDoubleArray(Generate2DimDoubleArray(n, m));

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int n2 = random.Next(1, 10);
// int m2 = random.Next(1, 10);
// double[,] ar2 = Generate2DimDoubleArray(n2, m2);

// Print2DimDoubleArray(ar2);
// Console.WriteLine("Укажите координаты элемента (x, y)");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > n2 - 1 || y > m2 -1 || x < 0 || y < 0) {
//     Console.WriteLine("Элемента не существует");
// } else {
//     Console.WriteLine("= " + ar2[x, y]);
// }

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[] GetAveragesFrom2DimIntArray(int[,] ar) {
    int[] result = new int[ar.GetLength(1)];
    // итерируем по столбцам
    for (int i = 0; i < ar.GetLength(1); i++) {
        int sum = 0;
        // а затем по строкам
        for (int j = 0; j < ar.GetLength(0); j++) {
            // суммируем элементы одного столбца
            sum += ar[j, i];
        }
        // получаем искомое, разделив сумму на кол-во строк
        result[i] = sum / ar.GetLength(0);
    }

    return result;
}

int n3 = random.Next(1, 10);
int m3 = random.Next(1, 10);
int[,] ar3 = Generate2DimIntArray(n3, m3);
Print2DimIntArray(ar3);

int[] averagesArray = GetAveragesFrom2DimIntArray(ar3);
string str = "[";
for (int i = 0; i < averagesArray.Length; i++) {
    str += averagesArray[i] + ", ";
}
str += "]";
Console.WriteLine(str);
