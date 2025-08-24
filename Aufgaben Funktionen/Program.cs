namespace Aufgaben_Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"Vor dem Swap: x = {x}, y = {y}");
            MyMath.Swap(ref x, ref y);
            Console.WriteLine($"Nach dem Swap: x = {x}, y = {y}");
        }
    }
}
