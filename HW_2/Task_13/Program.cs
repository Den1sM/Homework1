// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите трёхзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumElements = Convert.ToString(Num);
if (NumElements.Length > 2) 
{
Console.WriteLine("Третьей цифрой числа является "+ NumElements [2]);
}
else
{
Console.WriteLine("Третьей цифры нет");  
}
Console.ReadKey();