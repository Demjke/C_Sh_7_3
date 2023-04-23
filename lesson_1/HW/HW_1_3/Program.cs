// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Please input number");
int a = int.Parse(Console.ReadLine()!);

if ((a % 2 == 0) && a != 0) {
    Console.WriteLine("yes");
} else if (a == 0) {
    Console.WriteLine("a = 0");
}  else {
    Console.WriteLine("no");
}
