namespace SkipListOne
{
    public class Node
    {
        public Node[] Next { get; set; }
        public int Value { get; set; }

        public Node(int value, int level)
        {
            Value = value;
            Next = new Node[level];
        }
    }


}
