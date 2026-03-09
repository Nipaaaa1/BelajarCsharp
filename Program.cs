// Exception

try {
  Console.WriteLine("Division program, enter 1st number:");
  int x = Convert.ToInt16(Console.ReadLine());
  Console.WriteLine("Enter 2nd number:");
  int y = Convert.ToInt16(Console.ReadLine());
  Console.WriteLine($"Result is {x / y }");
} catch (DivideByZeroException e) {
  Console.WriteLine("You can't divide by zero");
  Console.WriteLine(e.Message);
} finally {
  Console.WriteLine("Proglam finished");
}
