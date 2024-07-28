namespace SkipListOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Util.GetRandomList(100);

            var a = new SkipList();
            a.AddRange(list);

            Console.WriteLine(a.Count());
            Console.WriteLine(Util.IsSorted(a.ToList()));

            a.Print();

        }
    }
}
