int MulNum(int num) {
    int all_mul = 1;

    for(int i = 1; i <= num; i++) {
        all_mul *= i;
    }
    return all_mul;
}

Console.WriteLine("Введите число");
int val = int.Parse(Console.ReadLine()!);
int result = MulNum(val);
Console.WriteLine(result);
