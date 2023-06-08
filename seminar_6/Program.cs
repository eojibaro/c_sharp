// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int PositiveNumbers(int[] ar) {
    int count = 0;
    for (int i = 0; i < ar.Length; i++) {
        if (ar[i] > 0) {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Веедите размер массива");
int arLen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Начинайте вводить числа");
int[] ar = new int[arLen];

for (int i = 0; i < arLen; i++) {
    string? input = Console.ReadLine();
    if (input != null) {
        ar[i] = Convert.ToInt32(input);
    } else {
        Console.WriteLine("Пустой ввод!");
        i--;
    }
}

Console.WriteLine("Кол-во положительных чисел = " + PositiveNumbers(ar));

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int[] CrossLinePoint(int k1, int b1, int k2, int b2) {
    // k1 * x + b1 = k2 * x + b2
    // k1*x-k2*x=b2-b1
    // x*(k1-k2)=b2-b1
    // x=(b2-b1)/(k1-k2)
    int[] result = new int[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;
}

Console.WriteLine("Задайте коэффициенты для первой прямой y = k1 * x + b1, [k1, b1]");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте коэффициенты для второй прямой y = k2 * x + b2, [k2, b2]");
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());

int[] point = CrossLinePoint(k1, b1, k2, b2);
Console.WriteLine("Точка пересечения функций = [" + point[0] + ", " + point[1] + "]");


