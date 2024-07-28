

namespace SkipListOne
{
    public class Util
    {
        private static Random Rand = new Random();

        public static List<int> GetRandomList(int length)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < length; i++)
            {
                list.Add(Rand.Next());
            }

            return list;
        }

        public static bool IsSorted(List<int> a)
        {
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i - 1] > a[i])
                {
                    return false;
                }
            }

            return true;
        }



    }
}
