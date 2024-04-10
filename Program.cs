internal class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int X = 99; // Add Value
        int index = 8; // Vi tri de add.

        if (index <= 1 || index >= array.Length - 1)
        {
            Console.WriteLine("Khong the Add vao Array.");
            return; // Exit
        }
        for (int i = array.Length - 1; i > index; i--)
        {
            array[i] = array[i - 1];
        }
        array[index] = X;

        foreach (int element in array)
        {
            Console.Write(element + ",");
        }
    }
}