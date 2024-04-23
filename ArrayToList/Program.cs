using System.Diagnostics;

namespace homemadeList;
internal class Program
{
    static void Main()
    {
        myList<byte> myList = new myList<byte>();

        List<string> elapsed = new List<string>();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int j = 0; j < 1000000000; j++)
        {

            myList.Add(1);

        }
        stopwatch.Stop();
        elapsed.Add(stopwatch.ElapsedMilliseconds.ToString());

        List<int> fix = new List<int>();

        foreach (var item in elapsed)
        {
            fix.Add(int.Parse(item));
        }
        Console.WriteLine(fix.Average());


        //Console.WriteLine(elapsed);
    }
}
internal class myList<T>
{
    private T[] array = new T[2];
    private int count = 0;

    public void Add(T item)
    {
        if (count == array.Length)
        {
            Array.Resize(ref array, count);
        }
        array[array.Length - 1] = item;
        count++;
    }
}