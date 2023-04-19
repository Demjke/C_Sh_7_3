void Equation(double k1, double b1, double k2, double b2) {
    double sub = k1 - k2;
    if (sub != 0) {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Point : ({x}; {y})");
    } else if (k1 == k2 && b1 == b2) {
        Console.WriteLine("Infinite");
    } else {
        Console.WriteLine("no points");
    }
}

double k_1 = double.Parse(Console.ReadLine()!);
double b_1 = double.Parse(Console.ReadLine()!);
double k_2 = double.Parse(Console.ReadLine()!);
double b_2 = double.Parse(Console.ReadLine()!);

Equation(k_1, b_1, k_2, b_2);