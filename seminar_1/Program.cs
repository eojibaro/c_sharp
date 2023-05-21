// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    Console.WriteLine("Первое число больше " + a);
} else {
    Console.WriteLine("Второе число больше " + b);
}

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Вводите по порядку три числа");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int x3 = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(Math.Max(x1, x2), x3);
Console.WriteLine("Максимальное из них - " + max);

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());
if (c % 2 == 0) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
string result = "";
while (i < n) {
    if (i % 2 == 0) {
        result += i + " ";
    }
    i++;
}
Console.WriteLine(result);
