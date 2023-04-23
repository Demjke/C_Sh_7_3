Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine()!);

void divide (int num1, int num2) {  
    if (num1 % num2 == 0) {
        Console.WriteLine("кратно");
    } else {
        Console.WriteLine("не кратно, остаток ");
        Console.WriteLine(num1 % num2);
    }
}
divide(num1, num2);