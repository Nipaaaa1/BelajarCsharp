// Methods

SayHello("Nipa");
SayHelloMultiple("Jamal", "Udin", "Asep");

void SayHello(String name) {
  Console.WriteLine("Hello, " + name);
}

void SayHelloMultiple(params String[] names) {
  Console.WriteLine("Multiple!");
  foreach(String name in names) {
    Console.WriteLine("Hello, " + name);
  }
}
