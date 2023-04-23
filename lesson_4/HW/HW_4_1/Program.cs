int SqNum(int a, int b) {
    int sq = 1;

    for(int i = 1; i <= b; i++) {
        sq *= a;
    }
    return sq;
}

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);

int result = SqNum(a, b);
Console.WriteLine(result);
