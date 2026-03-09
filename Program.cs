// Polymorphism

Cat cat = new Cat();
Dog dog = new Dog();

Animal[] animals = { cat, dog };

foreach(Animal animal in animals) {
  animal.Sound();
}

class Animal {
  public virtual void Sound(){}
}

class Dog : Animal {
  public override void Sound() {
    Console.WriteLine("The dog goes woff");
  }
}

class Cat : Animal {
  public override void Sound() {
    Console.WriteLine("The cat goes meow");
  }
}
