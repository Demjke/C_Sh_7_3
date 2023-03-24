// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Polindrom(int num) {
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num4 = (num % 100) / 10;
    int num5 = (num % 100) % 10;
    if (num1 == num5 && num2 == num4) {
        Console.WriteLine("да");
    } else {
        Console.WriteLine("нет");
    }
}
Console.WriteLine("Введите 5-значное число");
int num = int.Parse(Console.ReadLine()!);

Polindrom(num);