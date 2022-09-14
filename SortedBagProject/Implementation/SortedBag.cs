using SortedBagProject.Interfaces;

namespace SortedBagProject.Implementation
{
    public class SortedBag : ISortedBag
    {
        public int Count { get; private set; }

        public bool IsEmpty 
        { 
            get
            {
                return Count == 0;
            }
        }

        public List<int> Items { get; private set; }

        public SortedBag()              // O(1)
        {
            Items = new List<int>();
            Items.Add(0);   // Dummy placeholder
            Count = 0;
        }

        public void Add(int number)     // O(n log n)
        {
            Items.Add(number);
            Count++;
            SiftUp();

            // used with a simple list
            // O(n log n)
            //Items.Sort();    

            // alternative to sorting: insertion into correct position of the list
            // O(n)
            //int i = Items.Count - 1;  
            //while (i > 0 && Items[i - 1] > number)
            //{
            //    Items[i] = Items[i - 1];
            //    i--;
            //}
            //Items[i] = number;
        }

        public void Clear()     // O(n)
        {
            Items.Clear();
            Items.Add(0);   // Dummy placeholder
            Count = 0;
        }

        public int Fetch() // O(log n)
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("SortedBag is empty");
            }
            int number = Items[1];
            Items[1] = Items[Count];
            Items.RemoveAt(Count);
            Count--;
            SiftDown();
   
            return number;
        }

        public int Peek()       // O(1)
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("SortedBag is empty");
            }
            return Items[1];
        }

        private void SiftUp()       // O(log n)
        {
            int i = Count;
            while (i > 1 && Items[i / 2] > Items[i])
            {
                Swap(i, i / 2);
                i /= 2;
            }
        }

        private void SiftDown()     // O(log n)
        {
            int i = 2;
            while (i <= Count)
            {
                if (i < Count && Items[i] > Items[i+1])
                    i++;
                if (Items[i] < Items[i / 2])
                    Swap(i, i / 2);
                i *= 2;
            }
        }

        private void Swap(int i, int j)  // O(1)
        {
            int tmp = Items[i];
            Items[i] = Items[j];
            Items[j] = tmp;
        }
    }
}
