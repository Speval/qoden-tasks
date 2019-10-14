using System;

namespace task1
{
    class ListNode<T>
    {
        public ListNode()
        {
            next = null;
        }

        T value;
        ListNode<T> next;
        public void Insert(T newValue)
        {
            ListNode<T> lastNode = this;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }

            var newLastNode = new ListNode<T>() { value = newValue };
            lastNode.next = newLastNode;
        }
        public void PrintListValues()
        {
            ListNode<T> curNode = this.next;
            do
            {
                Console.Write($"{curNode.value} ");
                curNode = curNode.next;
            }
            while (curNode != null);
        }
    }
}
