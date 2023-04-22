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

int[] SumElem(int[,] arr) {
    int row = arr.GetLength(0);
    int[] nums = new int[row];
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            nums[i] += arr[i, j];
        }
    }
    return nums;
}

void Min(int[] arr) {
    int min = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] < arr[min]) {
            min = i;
        }
    }
    Console.Write($"{arr[min]} ");
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

int[] sum = SumElem(mass);
Min(sum);