// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int start = 1;
if (num > 2) {
start = start + 1;
do {
Console.Write(start + ", ");
start = start + 2;
}
while (start < num - 2);
Console.WriteLine(start + ".");
}
else 
if (num == 2) Console.WriteLine("в промежутке от 1 до 2 не содержится четных чисел");