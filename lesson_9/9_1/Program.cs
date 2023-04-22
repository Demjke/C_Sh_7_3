Console.Write("Enter number M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter number N: ");
int n = int.Parse(Console.ReadLine()!);

void Natural (int M, int N) {
    if (M > N) {
        return;
    } 
    Natural(M, N - 1);
    Console.Write($"{N} ");
}
Natural(m, n);
