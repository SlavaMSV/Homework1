// Задача нахождения максимального из двух чисел
Console.WriteLine("Введите 2 числа:");
string astr = Console.ReadLine();
string bstr = Console.ReadLine();
int a = Convert.ToInt32(astr);
int b = Convert.ToInt32(bstr);
if(a > b)
Console.WriteLine($"max = {a}");
else if(a < b)
Console.WriteLine($"max = {b}");
else if(a==b)
Console.WriteLine("числа равны");
