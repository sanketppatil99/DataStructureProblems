using DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {

        
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;


            }

            Console.WriteLine("{0} inserted into Linked List ", node.data);
        }
       
        public void InsertNode(int position, int data)
        {
            var newnode = new Node(data);

            newnode.data = data;
            newnode.next = this.head;
            if (position < 1)
            {
                Console.WriteLine("invalid data");
            }
            if (position == 1)
            {
                newnode.next = this.head;
                head = newnode;
            }
            else
            {
                Node node1 = new Node(data);
                node1 = this.head;

                while (position > 2)
                {
                    node1 = node1.next;
                    position--;
                }

                newnode.next = node1.next;
                node1.next = newnode;

            }
        }
        
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }


    }
}