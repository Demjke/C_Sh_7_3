string binary(int num) {
    string result = "";
    while (num > 0) {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

int x = int.Parse(Console.ReadLine()!);
Console.WriteLine(binary(x));