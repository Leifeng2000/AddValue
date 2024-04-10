internal class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[] {53, 32, 85, 16, 89, 46, 84, 60, 69, 11};
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