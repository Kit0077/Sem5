Console.WriteLine("Введите A(x): ");
int A1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите A(y): ");
int A2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите A(z): ");
int A3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B(x): ");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B(y): ");
int B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B(z): ");
int B3 = Convert.ToInt32(Console.ReadLine());

double dlina = Math.Sqrt(Math.Pow((A1 - B1), 2) + Math.Pow((A2 - B2), 2) + Math.Pow((A3 - B3), 2));

Console.WriteLine($"Растояние между точками {dlina:f2}");