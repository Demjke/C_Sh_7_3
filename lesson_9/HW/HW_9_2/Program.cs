Console.Write("Enter number M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter number N: ");
int n = int.Parse(Console.ReadLine()!);

int Natural (int M, int N) {
    int sum = 0;
    if (M > N) {
        return sum;
    } 
    if (N % 2 != 0) {
        return Natural(M, N - 1);
    } 
    if (N % 2 == 0) {
        return sum += Natural(M, N - 2);
    } else {
        return sum;
    }
}
Console.Write(Natural(m, n));
