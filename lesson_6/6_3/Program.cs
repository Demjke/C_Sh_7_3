﻿void Fibb(int num) {
    int a = 0;
    int b = 1;
    for (int i = 0; i < num; i++) {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);         
    }
}

int x = int.Parse(Console.ReadLine()!);
Fibb(x);