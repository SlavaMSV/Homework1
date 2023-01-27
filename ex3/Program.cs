// Программа проверки четности числа
Console.WriteLine("Введите число:");
string nstr = Console.ReadLine();
int n = Convert.ToInt32(nstr);
if(n % 2 == 0)
Console.WriteLine($"{n} - четное число");
else 
Console.WriteLine($"{n} - нечетное число");
