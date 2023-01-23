// See https://aka.ms/new-console-template for more information

ListNode head = new ListNode(1);
head.next = new ListNode(2);  
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);
head.next.next.next.next.next = new ListNode(6);
Solution s = new Solution();
var answer = s.OddEvenList(head);
while (answer != null)
{
  Console.WriteLine(answer.val);
  answer = answer.next;
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

public class Solution
{
  public ListNode OddEvenList(ListNode head)
  {
    if (head == null) return head;
    var odd = head;
    var proxy1 = odd;
    var even = head.next;
    var proxy2 = even;
    while (even != null && even.next != null && odd != null && odd.next != null)
    {
      odd.next = even.next;
      odd = odd.next;
      even.next = odd.next;
      even= even.next;  
    }
    odd.next = proxy2;
    return proxy1;
  }
}