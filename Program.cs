namespace _86._Partition_List
{
    internal class Program
    {
        public class ListNode 
        {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode Partition(ListNode head, int x)
        {
            if (head == null) return null;
            ListNode ptr = head;
            ListNode lessPtr = null,lessHead = null,greaterPrev = null, lessPrev = null, greaterPtr = null , greaterHead = null;
            while(ptr != null)
            {
                if (ptr.val < x) 
                {
                    lessPrev = lessPtr;
                    lessPtr = new ListNode(ptr.val);
                    if (lessPrev != null) lessPrev.next  = lessPtr;
                    if (lessHead == null) lessHead = lessPtr;


                }
                else
                {
                    greaterPrev = greaterPtr;
                    greaterPtr = new ListNode(ptr.val);
                    if (greaterPrev != null) greaterPrev.next = greaterPtr;

                    if (greaterHead == null) greaterHead = greaterPtr;


                }
                ptr = ptr.next;
            }
            if(lessPtr != null) lessPtr.next = greaterHead;
            return lessHead == null ? greaterHead : lessHead;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}