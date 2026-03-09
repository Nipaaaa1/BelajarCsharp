// Getter & Setter

Person person = new Person("Nipa", "NEET");

person.Greetings();

person.JobTitle = "Web developer";
person.Greetings();

class Person {
  private String name;
  private String jobTitle;

  public Person(String name, String jobTitle) {
    this.name = name;
    this.jobTitle = jobTitle;
  }

  public String JobTitle {
    get { return jobTitle; }
    set { jobTitle = value; }
  }

  public void Greetings() {
    Console.WriteLine($"Hello, my name is {name}. I'm a {jobTitle}");
  }
}
