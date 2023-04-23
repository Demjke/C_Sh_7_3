int Sum (int x) {
    if (x == 0) {
        return 0;
    } 
    return x % 10 + Sum(x / 10);
}
Console.Write(Sum(1263));