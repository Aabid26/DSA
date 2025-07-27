using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Common_Coding_Question.Linked_Lists.Model
{
    public class ListNode
    {
        public int val {  get; set; }
        public ListNode next { get; set; }
        public  ListNode(int val,ListNode next = null)
        {
           this.val = val;
           this.next = next;
        }
    }
}
