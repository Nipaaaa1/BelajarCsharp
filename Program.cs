// Generic

int[] numbers1 = { 1, 2, 3 };
double[] numbers2 = { 1.0, 2.0, 3.0 };

PrintArray(numbers1);
PrintArray(numbers2);

void PrintArray<T>(T[] arrays) {
  foreach(T item in arrays) {
    Console.Write(item + " ");
  }
  Console.WriteLine();
}
