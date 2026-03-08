// Number Guessing Game

Console.WriteLine("Welcome to Number Guessing Game");

Random random = new Random();

int hiddenNumber = random.Next(1, 101);
int guess = 0;

while(hiddenNumber != guess) {
  Console.WriteLine("Pick a number between 1 - 100:");
  guess = Convert.ToInt16(Console.ReadLine());
  
  if(guess > hiddenNumber) {
    Console.WriteLine("Too high!");
  } else if(guess < hiddenNumber) {
    Console.WriteLine("Too low!");
  }
}

Console.WriteLine("You win! The number is: " + guess);
