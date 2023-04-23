Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a == b * b) {
    Console.WriteLine("yes");
} else {
    Console.WriteLine("no");
}