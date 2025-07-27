using DSA.Common_Coding_Question.Linked_Lists.Model;
using DSA.Common_Coding_Question.Linked_Lists.Singly_Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Common_Coding_Question.Linked_Lists
{
    public class FindMiddleElement
    {
        //Tortoise and Hare approach
        public static int GetElement(ListNode headNode)
        {
            ListNode fastPoint = headNode;
            ListNode slowPoint= headNode;
            while(fastPoint.next != null && fastPoint.next.next!=null)
            {
                slowPoint=slowPoint.next;
                fastPoint = fastPoint.next.next;
            }
            //fastPoint = headNode.next;
            return slowPoint.val;
        }
    }
}
