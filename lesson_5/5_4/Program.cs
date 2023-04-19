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

int[] ProductArr(int[] arr) {
    int len = arr.Length;
    int[] result = new int[len / 2 + len % 2];

    for (int i = 0; i < len / 2; i++) {
        result[i] = arr[i] * arr[len - i - 1];
    }

    if (len % 2 == 1) {
        result[result.Length - 1] = arr[len / 2];
    }
    return result;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = EightMass(num, start, stop);
Print(mass);
int[] endArr = ProductArr(mass);
Print(endArr);