int TakeNum(int num) {
    Console.WriteLine(num);
    int num1 = num / 10;
    int num2 = num1 % 10;
    if (num1 > num2) return num1;
    return num2;
}
int th_num = TakeNum(new Random().Next(10, 100));
Console.WriteLine(th_num);