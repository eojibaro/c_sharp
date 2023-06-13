Random random = new Random();

void Print2DimStringArray(string[,] ar) {
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

int[,] Generate2DimIntArray(int n, int m, int min = 0, int max = 100) {
    int[,] ar = new int[n, m];
    Random random = new Random();

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            ar[i, j] = random.Next(min, max);
        }
    }

    return ar;
}

int[,,] Generate3DimIntArray(int x, int y, int z, int min = 0, int max = 100) {
    int[,,] ar = new int[x, y, z];
    Random random = new Random();

    for (int i = 0; i < x; i++) {
        for (int j = 0; j < y; j++) {
            for (int k = 0; k < z; k++) {
                ar[i, j, k] = random.Next(min, max);
            }
        }
    }

    return ar;
}

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] Sort2DimIntArray(int[,] ar) {
    for (int i = 0; i < ar.GetLength(0); i++) {
        for (int j = 0; j < ar.GetLength(1); j++) {
            for (int k = j + 1; k < ar.GetLength(1); k++) {
                if (ar[i, j] < ar [i, k]) {
                    int tmp = ar[i, k];
                    ar[i, k] = ar[i, j];
                    ar[i, j] = tmp;
                }
            }
        }
    }
    return ar;
}

int n1 = random.Next(1, 10);
int m1 = random.Next(1, 10);
int[,] ar1 = Generate2DimIntArray(n1, m1);
Print2DimIntArray(ar1);

int[,] sortedAr1 = Sort2DimIntArray(ar1);
Print2DimIntArray(sortedAr1);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int GetRowMinSum(int[,] ar) {
    int? minSum = null;
    int minSumRowIndex = 0;
    for (int i = 0; i < ar.GetLength(0); i++) {
        int tmp = 0;
        for (int j = 0; j < ar.GetLength(1); j++) {
            tmp += ar[i, j];
        }
        if (minSum == null || tmp < minSum) {
            minSum = tmp;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}

int n2 = random.Next(2, 10);
int m2 = random.Next(2, 10);
int[,] ar2 = Generate2DimIntArray(n2, m2);
Print2DimIntArray(ar2);

Console.WriteLine("Строка с наименьшей суммой элементов = " + GetRowMinSum(ar2));

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] MatrixMultiplication(int[,] ar1, int[,] ar2) {
    int[,] result = new int[ar1.GetLength(0), ar2.GetLength(1)];
    for (int i1 = 0; i1 < ar1.GetLength(0); i1++) {
        for (int j1 = 0; j1 < ar1.GetLength(1); j1++) {
            for (int j2 = 0; j2 < ar2.GetLength(1); j2++) {
                for (int i2 = 0; i2 < ar2.GetLength(0); i2++) {
                    result[i1, j2] += ar1[i1, j1] * ar2[i2, j2];
                }
            }
        }
    }
    return result;
}

int n3 = random.Next(2, 5);
int m3 = random.Next(2, 5);
int[,] ar3 = Generate2DimIntArray(n3, m3, 1, 10);
Print2DimIntArray(ar3);
// Чтобы можно было умножить две матрицы, количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.
int n4 = m3;
int m4 = random.Next(2, 5);
int[,] ar4 = Generate2DimIntArray(n4, m4, 1, 10);
Print2DimIntArray(ar4);

Print2DimIntArray(MatrixMultiplication(ar3, ar4));

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
int x = 2;
int y = 2;
int z = 2;

int[,,] ar5 = Generate3DimIntArray(x, y, z, 10, 99);

for (int i = 0; i < ar5.GetLength(0); i++) {
    for (int j = 0; j < ar5.GetLength(1); j++) {
        string str = "";
        for (int k = 0; k < ar5.GetLength(2); k++) {
            str += ar5[i, j, k] + " (" + i + ", " + j + ", " + k + ")\t";
        }
        Console.WriteLine(str);
    }
}

// Напишите программу, которая заполнит спирально массив 4 на 4.
string[,] Generate2DimIntSpiral(int n, int m) {
    string[,] result = new string[n, m];

    int k = 1;
    int i = 0;
    int j = 0;
    // переменные, ограничивающие спираль
    int iStart = 0;
    int iEnd = n;
    int jStart = 1;
    int jEnd = m;

    // направление итерирования. 0 = слева направо, 1 = сверху вниз, 2 = справа налево, 3 = снизу вверх
    int r = 0;

    while (k <= n * m) {
        if (k >= 10) {
            result[j, i] = Convert.ToString(k);
        } else {
            result[j, i] = "0" + Convert.ToString(k);
        }

        switch (r) {
            case 0:
                if (i < iEnd - 1) {
                    i++;
                } else {
                    iEnd--;
                    j++;
                    r = (r + 1) % 4;
                }
                break;
            case 1:
                if (j < jEnd - 1) {
                    j++;
                } else {
                    jEnd--;
                    i--;
                    r = (r + 1) % 4;
                }
                break;
            case 2:
                if (i > iStart) {
                    i--;
                } else {
                    iStart++;
                    j--;
                    r = (r + 1) % 4;
                }
                break;
            case 3:
                if (j > jStart) {
                    j--;
                } else {
                    jStart++;
                    i++;
                    r = (r + 1) % 4;
                }
                break;
        }
        
        k++;
    }

    return result;
}

int n6 = 4;
int m6 = 4;
string[,] ar6 = Generate2DimIntSpiral(n6, m6);
Print2DimStringArray(ar6);