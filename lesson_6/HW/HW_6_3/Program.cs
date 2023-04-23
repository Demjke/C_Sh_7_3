void Print(int[] arr) {
    int size = arr.Length;

    for (int i = 0; i < size; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] EightMass(int size, int from, int to) {
    int[] arr = new int[size];

    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void CopyMass(int[] arr) {
    int row = arr.Length;
    int column = arr.Length;
    int size = arr.Length;
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {

        }
    }
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = EightMass(num, start, stop);
Print(mass);
CopyMass(mass);
Print(mass);