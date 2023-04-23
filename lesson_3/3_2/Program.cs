double distance(int x1, int y1, int x2, int y2) {
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
double result = distance(x1, y1, x2, y2);
Console.WriteLine(result);