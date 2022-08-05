/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

Console.Write("Enter number n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Enter number m: ");
int m = int.Parse(Console.ReadLine()!);

int Ankerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Ankerman(n - 1, 1);
    if (n > 0 && m > 0) return Ankerman(n - 1, Ankerman(n, m - 1));
    return Ankerman(n, m);
}
Console.WriteLine(Ankerman(n,m));