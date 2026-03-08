// Type Casting

int a = 10;
double b = Convert.ToDouble(a) + 0.1;
String c = Convert.ToString(a);

String d = "=";
char e = Convert.ToChar(d);

const String f = "false";
bool g = Convert.ToBoolean(f);

Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());
Console.WriteLine(c.GetType());
Console.WriteLine(e.GetType());
Console.WriteLine(g.GetType());
