﻿void Print(int[] arr) {
    int size = arr.Length;

    for(int i = 0; i < size; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] EightMass(int size, int from, int to) {
    int[] arr = new int[size];

    for(int i = 0; i < size; i++) {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

bool TryFols(int[] arr, int des) {
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == des) {
            return true;
        }
    }
    return false;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = EightMass(num, start, stop);
Print(mass);
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(TryFols(mass, a));
Print(mass);