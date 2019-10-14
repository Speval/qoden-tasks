using System;

namespace task1
{
    class HashTable
    {
        private int divider;
        public HashTable(int divider)
        {
            this.divider = divider;
            values = new ListNode<int>[divider];
        }
        public ListNode<int>[] values;
        public void Insert(int newValue)
        {
            int hash = MyHashFunk(newValue);
            if (values[hash] == null)
            {
                values[hash] = new ListNode<int>();
            }
            values[hash].Insert(newValue);
        }
        private int MyHashFunk(int value)
        {
            return value % divider;
        }
        public void PrintAllValues()
        {
            for (int i = 0; i < divider; i++)
            {
                Console.Write($"{i}: ");
                if (values[i] != null)
                {
                    values[i].PrintListValues();
                }
                Console.WriteLine();
            }
        }
    }
}
