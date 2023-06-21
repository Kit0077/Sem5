Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string NumberToString = Convert.ToString(number);
int lenght = NumberToString.Length;

if (lenght == 5)
{
    if (NumberToString[0] == NumberToString[4] && NumberToString[1] == NumberToString[3])
    {
        Console.WriteLine("Ваше число является палиндромом");
    }
    else Console.WriteLine("Ваше число не палиндром");
} 
else Console.WriteLine("Выше число не пятизначное");