Console.Clear();

Console.WriteLine("Введите 5-ти значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1999 || n > 100000 )
{
    if(n < 1999)
    {
    Console.WriteLine("Вы ошиблись! Введите 5-ти значное число: ");
    n = Convert.ToInt32(Console.ReadLine());
    }
    if(n > 100000)
    {
    Console.WriteLine("Вы ошиблись! Введите 5-ти значное число: ");
    n = Convert.ToInt32(Console.ReadLine());
    }
}
int e, d, s, t, dt;
e = n % 10;
d = (n % 100) / 10;
s = (n % 1000) / 100;
t = (n % 10000) / 1000;
dt = n / 10000;
if(dt == e && t == d)
{
    Console.WriteLine("Является палиндромом!");
}
else
{
    Console.WriteLine("Не является палинлиндромом!");
}

