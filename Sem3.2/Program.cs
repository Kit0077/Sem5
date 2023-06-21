Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= number; i++)
{
    int itog = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine(itog);
}