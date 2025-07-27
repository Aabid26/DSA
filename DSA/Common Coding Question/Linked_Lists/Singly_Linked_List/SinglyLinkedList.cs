using DSA.Common_Coding_Question.Linked_Lists.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Common_Coding_Question.Linked_Lists.Singly_Linked_List
{
    public class SinglyLinkedList
    {
        public ListNode head;
        public void InsertAtEnd(int val)
        {
            if(head == null)
            {
                head = new ListNode(val);
            }
            else
            {
                ListNode listNode = new ListNode(val);
                ListNode currentNode = head;
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = listNode;
            }
        }
        public string PrintList()
        {
            string value = "";
            ListNode Node = head;
            while (Node.next != null)
            {
                value +=Node.val + " -> ";
                Node = Node.next;
            }
            value += Node.val;
            return value;
        }
    }
}
