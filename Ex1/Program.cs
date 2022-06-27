Console.WriteLine ("Введите число 1: ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число 2: ");
int b = Convert.ToInt32 (Console.ReadLine ());
int c= a%b;
if (c==0) 
{
    Console.WriteLine ("Число {0} кратно числу {1}", a, b);
}
else
{
    Console.WriteLine ("Остаток от деления: " + c);
}
