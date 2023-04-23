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

void averageColumns(int[,] arr) {
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    double x;
     for (int i = 0; i < column_size; i++) {
        x = 0;
        for (int j = 0; j < row_size; j++) {
            x += arr[j, i];
        }
        Console.Write($"{Math.Round(x / row_size)}; ");
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
averageColumns(mass);
