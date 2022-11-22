// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day <= 5) 
{
    Console.WriteLine("Этот день не является выходным");
}
if (Day == 6)
{
    Console.WriteLine("Этот день - выходной");  
}
if (Day == 7)
{
    Console.WriteLine("Этот день - выходной");  
}
if (Day > 7)
{
   Console.WriteLine("Ошибка - в неделе 7 дней");   
}
