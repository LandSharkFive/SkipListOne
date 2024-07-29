
namespace SkipListOne
{
    public class SkipList
    {
        // Allows duplicates.

        private const int MAXLEVEL = 10;
        private const double EXPECTED = 0.1;

        private Node Head = new Node(0, MAXLEVEL);
        private Random Rand = new Random();

        /// <summary>
        /// Inserts a value into the skip list.
        /// </summary>
        public void Insert(int value)
        {
            int level = RandomLevel();

            // Insert newNode into the skip list
            Node newNode = new Node(value, level + 1);
            Node cur = Head;
            for (int i = MAXLEVEL - 1; i >= 0; i--)
            {
                while (cur.Next[i] != null)
                {
                    if (cur.Next[i].Value > value)
                    {
                        break;
                    }

                    cur = cur.Next[i];
                }

                if (i <= level)
                {
                    newNode.Next[i] = cur.Next[i];
                    cur.Next[i] = newNode;
                }
            }
        }

        // Get Random Level with a 10% probability.
        private int RandomLevel()
        {
            int level = 0;
            while (level < MAXLEVEL && Rand.NextDouble() < EXPECTED)
            {
                ++level;
            }

            return level;
        }

        public void Clear()
        {
            Array.Clear(Head.Next);
        }

        public bool IsEmpty()
        {
            return Head.Next[0] == null;
        }


        /// <summary>
        /// Count
        /// </summary>
        /// <returns>int</returns>
        public int Count()
        {
            int count = 0;
            Node cur = Head.Next[0];
            while (cur != null)
            {
                ++count;
                cur = cur.Next[0];
            }
            return count;
        }


        /// <summary>
        /// Is value in skip list?
        /// </summary>
        public bool Contains(int value)
        {
            Node cur = Head;
            for (int i = MAXLEVEL - 1; i >= 0; i--)
            {
                while (cur.Next[i] != null)
                {
                    if (cur.Next[i].Value > value)
                    {
                        break;
                    }
                    if (cur.Next[i].Value == value)
                    {
                        return true;
                    }
                    cur = cur.Next[i];
                }
            }
            return false;
        }

        /// <summary>
        /// Remove a value from the skip list. 
        /// </summary>
        public void Remove(int value)
        {
            Node cur = Head;
            for (int i = MAXLEVEL - 1; i >= 0; i--)
            {
                while (cur.Next[i] != null)
                {
                    if (cur.Next[i].Value == value)
                    {
                        cur.Next[i] = cur.Next[i].Next[i];
                        break;
                    }
                    if (cur.Next[i].Value > value)
                    {
                        break;
                    }
                    cur = cur.Next[i];
                }
            }
        }


        /// <summary>
        /// Produces an enumerator that iterates over elements in the skip list in order.
        /// </summary>
        public IEnumerable<int> Enumerate()
        {
            Node cur = Head.Next[0];
            while (cur != null)
            {
                yield return cur.Value;
                cur = cur.Next[0];
            }
        }

        public void AddRange(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Insert(list[i]);
            }
        }

        public void RemoveRange(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Remove(list[i]);
            }
        }

        public void Print()
        {
            Node cur = Head.Next[0];
            while (cur != null)
            {
                Console.Write(cur.Value);
                Console.Write(" ");
                cur = cur.Next[0];
            }
            Console.WriteLine();
        }

        public List<int> ToList()
        {
            List<int> list = new List<int>();
            Node cur = Head.Next[0];
            while (cur != null)
            {
                list.Add(cur.Value);
                cur = cur.Next[0];
            }
            return list;
        }

    }
}