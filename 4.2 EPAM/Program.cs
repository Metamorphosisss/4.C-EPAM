int length = Convert.ToInt32(Console.ReadLine());
int width = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[width, length];
for (int i = 0; i < width; i++)
{
    for (int j = 0; j < length; j++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int min = array[0, 0];
int max = array[0, 0];

for (int i = 0; i < width; i++)
{
    for (int j = 0; j < length; j++)
    {
        if (min > array[i, j])
        {
            min = array[i, j];
        }
        if (max < array[i, j])
        {
            max = array[i, j];
        }
    }
}
Console.WriteLine("Сума min i max" + (min + max));