using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancolLista
{
    internal class LinkedList<LT>
    {

        private LinkedListNode<LT>? head;

        public void Add(LT value) { 
            
            LinkedListNode<LT> newNode = new LinkedListNode<LT>(value);

            if (head == null)
            {
                head = newNode;
            }
            else 
            { 
                LinkedListNode<LT> current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void AddStart(LT value) {
            LinkedListNode<LT> newNode = new LinkedListNode<LT>(value);
            newNode.Next = head;
            head = newNode;
        }

        public bool Remove(LT searchedValue) {
            if (head == null)
            {
                return false;
            }

            if (head.Value.Equals(searchedValue)) {
                head = head.Next;
                return true;
            }

            LinkedListNode<LT> current = head;
            while (current.Next != null && !current.Next.Value.Equals(searchedValue)) {
                current = current.Next;
            }

            if (current.Next == null)
            {
                return false;
            }

            current.Next = current.Next.Next;
            return true;
        }

        public void PrintAll() {
            LinkedListNode<LT>? current = head;
            while (current != null) {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

    }
}
