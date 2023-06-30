// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] numbers = new int[8];
System.Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 101);
    System.Console.Write(" " + Method (i) + " ");
 }
System.Console.Write("]");

int Method (int a)
{
    return numbers[a];
}
