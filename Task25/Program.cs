Console.WriteLine("введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int i = numberA;

for (int j = 1; j < numberB; j++)
{
i = i * numberA;
}
Console.WriteLine("A в степени B равно: " + i);
