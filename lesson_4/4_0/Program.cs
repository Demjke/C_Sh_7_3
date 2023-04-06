int SumNum(int num) {
    int all_sum = 0;

    for(int i = 0; i <= num; i++) {
        all_sum += i;
    }
    return all_sum;
}

Console.WriteLine("Введите число");
int val = int.Parse(Console.ReadLine()!);
int result = SumNum(val);
Console.WriteLine(result);
