// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите 2 числа");
string? input1 = Console.ReadLine();
string? input2 = Console.ReadLine();

int Pow(int n1, int n2) {
    int result = n1;
    for (int i = 1; i < n2; i++) {
        result *= n1;
    }
    return result;
}

if (input1 != null && input2 != null) {
    Console.WriteLine(input1 + "^" + input2 + "=" + Pow(Convert.ToInt32(input1), Convert.ToInt32(input2)));
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
string? input3 = Console.ReadLine();

int DigitsSum(int n) {
    int result = 0;
    string strNum = Convert.ToString(n);
    for (int i = 0; i < strNum.Length; i++) {
        int digit = Convert.ToInt32(strNum.Substring(i, 1));
        result += digit;
    }
    return result;
}

if (input3 != null) {
    Console.WriteLine("Сумма цифр числе = " + DigitsSum(Convert.ToInt32(input3)));
}

//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите размер массива");
int arLen = Convert.ToInt32(Console.ReadLine());
string[] ar = new string[arLen];
string outputStr = "[";

Console.WriteLine("Ввводите числа, они будут заполняться в массив");
for (int i = 0; i < arLen; i++) {
    string? input = Console.ReadLine();
    if (input != null) {
        ar[i] = input;
        outputStr += input;
    } else {
        ar[i] = "0";
        outputStr += "0";
    }
    if (i != arLen - 1) outputStr += ", ";
}
outputStr += "]";
Console.WriteLine(outputStr);