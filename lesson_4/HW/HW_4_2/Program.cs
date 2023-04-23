int sumCount(int num) {
    int count = 0;
    for(int i = 1; num > 0; i++) {
        int numLast = num % 10;
        num /= 10;
        count += numLast; 
    }
    return count;
}

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int result = sumCount(a);
Console.WriteLine(result);