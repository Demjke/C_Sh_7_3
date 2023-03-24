void Coordinate(int a) {
    if (a == 1) {
        Console.WriteLine("x > 0, y > 0");
    } else if (a == 2) {
        Console.WriteLine("x > 0, y < 0");
    } else if (a == 3) {
        Console.WriteLine("x < 0, y < 0");
    } else {
        Console.WriteLine("x < 0, y > 0");
    }
}

int num = int.Parse(Console.ReadLine()!);
Coordinate(num);