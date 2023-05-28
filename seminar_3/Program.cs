int InputNumber(string str) {
    Console.WriteLine(str);
    string? input1 = Console.ReadLine();
    if (input1 != null) {
        return Convert.ToInt32(input1);
    }
    Console.WriteLine("Пустой ввод");
    return 0;
}

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string StrReverse(string str) {
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

bool IsPalindrom(int num) {
    string str = Convert.ToString(num);
    return str == StrReverse(str);
}

int num1 = InputNumber("Введите пятизначное число");
if (num1 >= 10000 && num1 <= 99999) {
    if (IsPalindrom(num1)) {
        Console.WriteLine("Это палиндром");
    } else {
        Console.WriteLine("Это НЕ палиндром");
    }
} else {
    Console.WriteLine("Неверный ввод");
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты 1 точки (x, y, z)");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты 2 точки (x, y, z)");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между этими точками - " + result);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int num3 = InputNumber("Введите число");
Console.WriteLine("Кубы этого числа:");
for (int i = 1; i <= num3; i++) {
    Console.WriteLine(i + "^3 = " + Math.Pow(i, 3));
}