using System;

namespace ConsoleApp1
{

}
class Array
{
    int[] array;
    public Array(int[] array)
    {
        this.array = array;
    }
    public bool IsUp()
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1]) return false;
        }
        return true;
    }
}
class Program
{
    static void Main()
    {
        Array array = new Array(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        Console.WriteLine(array.IsUp() ? "Возрастающая" : "Не возрастающая");
    }
}


