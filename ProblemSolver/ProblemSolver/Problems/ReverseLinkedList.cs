using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver.Problems
{
    internal static partial class Solution
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode next;
            ListNode prev = null;

            while (head != null)
            {
                next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
