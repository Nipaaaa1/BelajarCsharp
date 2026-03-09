// Interface

Rabbit rabbit = new Rabbit();
Wolf wolf = new Wolf();
Fish fish = new Fish();

rabbit.flee();
wolf.hunt();
fish.flee();
fish.hunt();

interface IPrey {  
  public void flee();
}

interface IPredator {
  public void hunt();
}

class Rabbit : IPrey {
  public void flee() {
    Console.WriteLine("The Rabbit is fleeing");
  }
}

class Wolf : IPredator {
  public void hunt() {
    Console.WriteLine("The Wolf is hunting");
    }
}

class Fish : IPrey, IPredator {
  public void flee() {
    Console.WriteLine("The fish swims away");
  }
  
  public void hunt() {
    Console.WriteLine("The fish is looking for a smaller fish");
  }
}
