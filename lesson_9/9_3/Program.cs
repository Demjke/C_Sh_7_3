int Natural (int a, int b) {
    if (b == 0) return 1; 
        return a * Natural(a, b - 1);
}

Console.Write(Natural(5, 3));