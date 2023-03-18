// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N..

Console.WriteLine("Please input number");
int a = int.Parse(Console.ReadLine()!);
int b = 2;
Console.WriteLine("Numbers: ");
while (a >= b) {
    Console.WriteLine(b);
    b += 2;
}
