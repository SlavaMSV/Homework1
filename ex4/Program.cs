// Программа показа четных чисел в диапозоне от 1 до N
Console.WriteLine("Введите положительное число:");
string nstr = Console.ReadLine();
int n = Convert.ToInt32(nstr);
int i = 2;
while(i <= n)
{
    Console.Write($"{i} ");
    i+=2;
}

