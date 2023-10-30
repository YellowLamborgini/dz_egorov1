Console.WriteLine("Введите число");
int chislo=Convert.ToInt32(Console.ReadLine());
if (chislo<1|chislo>100)
{
    Console.WriteLine("Ошибка");
}
else if (chislo%3==0& chislo %5 != 0)
{
    Console.WriteLine("Fizz");
}
else if (chislo % 5 == 0&chislo % 3 != 0)
{
    Console.WriteLine("Buzz");
}
else if (chislo % 5 == 0 & chislo % 3 == 0)
{
    Console.WriteLine("Fizz Buzz");
}
else
{
    Console.WriteLine($"Число:{ chislo}");
}