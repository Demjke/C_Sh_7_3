// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

void Day(int num) {
    if (num > 0 && num < 6 ) {
        Console.WriteLine("Будний день");
    } else if (num > 5 && num < 8 ) {
        Console.WriteLine("Выходной");
    } else {
        Console.WriteLine("Нет такого дня недели");
    }
}

Day(num);
