// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите трёхзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumElements = Convert.ToString(Num);
Console.WriteLine("Второй цифрой числа является "+ NumElements [1]);