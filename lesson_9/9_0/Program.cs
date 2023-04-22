Console.Write("Enter number N: ");
int num = int.Parse(Console.ReadLine()!);

void Natural (int N) {
    if (N == 0) {
        return;
    } 
    Natural(N - 1);
    Console.Write($"{N} ");
}
Natural(num);
