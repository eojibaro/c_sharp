//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
string GetNumbersRecoursive(int n, string str = "") {
    if (n > 0) {
        str += Convert.ToString(n) + " ";
        return GetNumbersRecoursive(n - 1, str);
    }
    return str;
}

Console.WriteLine("Введите число");
Console.WriteLine(GetNumbersRecoursive(Convert.ToInt32(Console.ReadLine())));

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int GetNumbersSumRecoursive(int m, int n, int sum = 0) {
    if (m != n) {
        if (m > n) {
            sum += GetNumbersSumRecoursive(m - 1, n, sum);
        } else {
            sum += GetNumbersSumRecoursive(m + 1, n, sum);
        }
    }
    return sum + m;
}

Console.WriteLine("Введите два числа по порядку");
int m1 = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма = " + Convert.ToInt32(GetNumbersSumRecoursive(m1, n1)));

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Ackerman(int n, int m) {
    while(n != 0) {
        if (m == 0) {
            m = 1;
        } else {
            m = Ackerman(n, m - 1);
        }
        n = n - 1;
    }
    return m + 1;
}

Console.WriteLine("Введите два неотрицательных числа по порядку");
int n2 = Convert.ToInt32(Console.ReadLine());
int m2 = Convert.ToInt32(Console.ReadLine());

if (n2 > 0 && m2 > 0) {
    Console.WriteLine(Ackerman(n2, m2));
} else {
    Console.WriteLine("Неверный ввод");
}
