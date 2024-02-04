Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a%7 ==0 && a%23 == 0)
{
    Console.WriteLine ($"{a} кратно одновременно 7 и 23");
}
else 
{
    Console.WriteLine ($"{a} не кратно одновременно 7 и 23");
}
