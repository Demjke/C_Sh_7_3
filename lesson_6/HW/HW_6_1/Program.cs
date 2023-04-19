string? x = Console.ReadLine();
int count = 1;
Console.WriteLine("Положительных чисел: " + count);
while (x != "") {
    int a = int.Parse(Console.ReadLine()!);
    if (a > 0) {
        count = count + 1;
        Console.WriteLine("Положительных чисел: " + count);
    } else {
        Console.WriteLine("Не положительное");
    }
}
