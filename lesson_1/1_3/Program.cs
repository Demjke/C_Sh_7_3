Console.WriteLine("Please input a number:");
int a = int.Parse(Console.ReadLine()!);
int b = -a;
while (a >= b) {
    Console.WriteLine(b);
    b++;
}
