void Print(int[,] arr) {
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++) {
        for (int j = 0; j < column_size; j++) {
            Console.Write($"{arr[i, j], 6} ");
        }
        Console.WriteLine();
    }
}

int[,] MassNums(int row, int column, int from, int to) {
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < column; j++) {
            arr[i, j] = new Random().Next(from, to + 1);
        }
    }
    return arr;
}

string FindElement(int[,] arr, int x, int y) {
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    if (x > row_size || y > column_size) {
        return "no element";
    } else {
        return $"Element: {arr[x - 1, y - 1]}";
    }
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the min number of massive: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);


Console.Write("Enter number of rows for search: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Enter number of columns for search: ");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine(FindElement(mass, x, y));
