void S(int n) {
    int a = 1;
    while (a <= n) {
        Console.WriteLine(a * a);
        a++;
    }
}

int n = int.Parse(Console.ReadLine()!);

S(n);