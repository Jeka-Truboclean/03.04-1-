using System.Collections.ObjectModel;

namespace _03._04_1_
{
    public class MyCollection<T> : Collection<T>
    {
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                return this.Items[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                this.Items[index] = value;
            }
        }
        public void AddItem(T item)
        {
            this.Add(item);
        }
        public bool RemoveItem(T item)
        {
            return this.Remove(item);
        }
        public bool ContainsItem(T item)
        {
            return this.Contains(item);
        }
        public void ClearCollection()
        {
            this.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<string> myCollection = new MyCollection<string>();
            myCollection.AddItem("Item 1");
            myCollection.AddItem("Item 2");
            myCollection.AddItem("Item 3");
            Console.WriteLine("Elements in collection:");
            for (int i = 0; i < myCollection.Count; i++)
            {
                Console.WriteLine(myCollection[i]);
            }
            myCollection.RemoveItem("Item 2");
            Console.WriteLine($"Contains 'Item 2': {myCollection.ContainsItem("Item 2")}");
            myCollection.ClearCollection();
            Console.WriteLine($"Collection is empty: {myCollection.Count == 0}");
        }
    }
}
