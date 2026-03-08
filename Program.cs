// Hypotenuse

Console.WriteLine("Masukkan sisi a:");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Masukkan sisi b:");
int b = Convert.ToInt16(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

Console.WriteLine("Hasilnya: " + result);
