﻿Console.WriteLine("Введите число:");
int num1 = int.Parse(Console.ReadLine()!);

void divide (int num1) {  
    if ((num1 % 7) == 0 && (num1 % 23) == 0) {
        Console.WriteLine("да");
    } else {
        Console.WriteLine("нет");
    }
}
divide(num1);