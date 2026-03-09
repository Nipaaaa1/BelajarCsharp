// Inheritence and abstract class

Programmer programmer1 = new Programmer("Nipa", 20, "Web Developer");

Programmer programmer2 = new Programmer("Jamal", 18, "Mobile Developer");

Programmer[] programmers = new Programmer[2];
programmers[0] = programmer1;
programmers[1] = programmer2;

foreach(Programmer programmer in programmers) {
  programmer.Greetings();
  programmer.JobTitle();
}

abstract class Person {
  protected String name;
  protected int age;
  
  public void Greetings() {
    Console.WriteLine($"Hello, I'm {name}. I'm {age} years old");
  }
}

class Programmer : Person {
  private String title;
  
  public Programmer(String name, int age, String title) {
    this.name = name;
    this.age = age;
    this.title = title;
  }

  public void JobTitle() {
    Console.WriteLine($"My job is {title}");
  }
}
