// Class

Car car1 = new Car("Revuelto", "Lamborghini");

car1.Drive();

Car.EngineSound();

class Car {
  private String name;
  private String maker;

  public Car(String name, String maker) {
    this.name = name;
    this.maker = maker;
  }

  public void Drive() {
    Console.WriteLine($"You're driving a {maker} {name}");
  }

  public static void EngineSound() {
    Console.WriteLine("Vroommmm...!!!");
  }
}
