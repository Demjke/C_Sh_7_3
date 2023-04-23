// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int NumThree(int num) {
    if (num < 100) {
        Console.WriteLine("третьей цифры нет");
        return num;
    } else if (num >= 100 && num <= 999){
        return num % 10;
    } else {
        while (num > 999) {
            num /= 10;
        }
        return num % 10;
    }
}

int result = NumThree(num);
Console.WriteLine(result);
