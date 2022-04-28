// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int start = 1;
do {
if (start % 2 == 0) {
Console.WriteLine(start + ", ");
start = start + 1;
} 
}
while (start < num);