void binArr(int num) {
    int[] arr = new int[num];
    for(int i = 0; i < num; i++) {
        arr[i] = new Random().Next(2);
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}
int len = int.Parse(Console.ReadLine()!);
binArr(len);

