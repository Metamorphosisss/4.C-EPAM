static void Main(string[] args)
{
    Console.WriteLine("введiть довжину масиву");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] masiv = new int[length];
    Console.WriteLine($"введiть {length} елементiв");
    for (int i = 0; i < length; i++)
    {
        masiv[i] = Convert.ToInt32(Console.ReadLine());
    }
    int summa = 0;
    int evennumbers = 0;
    foreach (int i in masiv)
    {
        if (i > 0)
        {
            summa += i;
        }
        if (i % 2 == 0)
        {
            evennumbers++;
        }
    }
    Console.WriteLine("наша сума додатнix" + summa);
    Console.WriteLine("кiлькiсть парних " + evennumbers);
}