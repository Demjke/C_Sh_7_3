// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите 3-х значное число");
int num = int.Parse(Console.ReadLine()!);

int NumTwo(int num) {
    int num1 = (num % 100) / 10;
    return num1;
}

int result = NumTwo(num);
Console.WriteLine(result);
