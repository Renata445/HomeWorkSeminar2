Console.Clear();

Console.WriteLine("Введите количество кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] a = new int[n];
int current_sum = 0, max_sum = 0, sum =0;
for(int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
    current_sum += a[i];
    if(current_sum > max_sum)
    {
        max_sum = current_sum;
    }

}
if(a[0] + a[n -1] + a[n - 2] > max_sum)
{
    max_sum = a[0] + a[n - 1] + a[n -2];
}
if(a[0] + a[1] + a[n - 1] > max_sum)
{
    max_sum = a[0] + a[1] + a[n - 1];
}
Console.WriteLine($"Максимальное число ягод, которое смог собрать за один заход собирающий модуль = {max_sum}");

