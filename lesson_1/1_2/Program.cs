﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input a number of day:");
int day = int.Parse(Console.ReadLine()!);

if (day == 1) {
    Console.WriteLine("Monday");
} else if (day == 2) {
    Console.WriteLine("Thuesday");
} else if (day == 3) {
    Console.WriteLine("Wednesday");
} else if (day == 4) {
    Console.WriteLine("Thursday");
} else if (day == 5) {
    Console.WriteLine("Friday");
} else if (day == 6) {
    Console.WriteLine("Saturday");
} else if (day == 7) {
    Console.WriteLine("Sunday");
} else {
    Console.WriteLine("No a day of week");
}