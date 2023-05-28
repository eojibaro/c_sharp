// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// функция, выдающая цифру заданного числа в ввиде строки
string SubNumber(int num, int n) {
    string str =  Convert.ToString(num);
    if (n > str.Length) {
        return "";
    }
    return str.Substring(n - 1, 1);
}

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
// проверка на трехзначность
if (num < 100 || num > 999) {
    Console.WriteLine("Неверный ввод, число не трехначное!");
} else {
    Console.WriteLine("Вторая цифра числа - " + SubNumber(num, 2));
}

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
string? input2 = Console.ReadLine();
// проверка на пустоту ввода
if (input2 != null) {
    int num2 = Convert.ToInt32(input2);
    string n = SubNumber(num2, 3);
    if (n.Length > 0) {
        Console.WriteLine("Третья цифра числа - " + n);
    } else {
        Console.WriteLine("Третьей цифры нет!");
    }
}

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели (числом от 1 до 7)");
string? input3 = Console.ReadLine();
if (input3 != null) {
    int num2 = Convert.ToInt32(input3);
    if (num2 >= 1 && num2 <= 7) {
        if (num2 == 6 || num2 == 7) {
            Console.WriteLine("Это выходной");
        } else {
            Console.WriteLine("Это рабочий день");
        }
    } else {
        Console.WriteLine("Неверный ввод");
    }
}