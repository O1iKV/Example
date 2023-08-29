//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
  int count = array.Length;
  int index = 0;
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(10);
}
  Console.Write("[");
  while(index < count){
    Console.Write(array[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
