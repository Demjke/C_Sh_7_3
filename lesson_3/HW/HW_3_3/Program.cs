﻿// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int n) {
    int a = 1;
    while (a <= n) {
        Console.WriteLine(a * a * a);
        a++;
    }
}
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);

Cube(n);