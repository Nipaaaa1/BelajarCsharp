// List

List<String> names = new List<String>();

names.Add("Nipa");
names.Add("Udin");
names.Add("Jamal");

foreach(String name in names) {
  Console.WriteLine(name);
}

names.Add("Rudi");
names.Remove("Jamal");
names.Sort();

foreach(String name in names) {
  Console.WriteLine(name);
}
