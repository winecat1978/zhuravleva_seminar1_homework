// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 0) {
    Console.WriteLine ("ноль не является ни четным, ни нечетным");
}
else
if (num % 2 == 0) {
    Console.WriteLine("число " + num + " четное");
}
else 
Console.WriteLine("число " + num + " нечетное");