// Задача нахождения максимального из трех чисел
Console.WriteLine("Введите 3 целых числа");
string astr = Console.ReadLine();
string bstr = Console.ReadLine();
string cstr = Console.ReadLine();
int a = Convert.ToInt32(astr);
int b = Convert.ToInt32(bstr);
int c = Convert.ToInt32(cstr);
int max = 0;
if ((a > b) && (a > c))
max = a;
else if ((b > a) && (b > c))
max = b;
else if ((c > a) && (c > b))
max = c;
Console.WriteLine($"максимальное число: {max}");
