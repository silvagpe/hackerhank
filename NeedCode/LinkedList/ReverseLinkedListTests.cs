
namespace NeedCode.LinkedList;

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
/// <summary>
/// https://neetcode.io/problems/reverse-a-linked-list
/// Reverse Linked List
///Given the beginning of a singly linked list head, reverse the list, and return the new beginning of the list.
///
///Example 1:
///
///Input: head = [0,1,2,3]
///
///Output: [3,2,1,0]
///Example 2:
///
///Input: head = []
///
///Output: []
///Constraints:
///
///0 <= The length of the list <= 1000.
///-1000 <= Node.val <= 1000
///
/// </summary>
public class ReverseLinkedListTests
{
    private ListNode GetListNode()
    {
        return new ListNode(0, new ListNode(1, new ListNode(2, new ListNode(3))));
    }

    [Fact]
    public void ReverseList()
    {
        var head = GetListNode();

        if (head.next == null)
        {
            Assert.True(true);
            return;
        }

        var stack = new Stack<ListNode>();

        var ptr = head;
        while (ptr != null)
        {
            stack.Push(ptr);
            ptr = ptr.next;
        }

        ptr = stack.Pop();
        while (stack.Count != 0)
        {
            var tmp = stack.Pop();


        }

        Assert.Equal(ptr.val, 3);
        Assert.Equal(ptr.next.val, 2);
        Assert.Equal(ptr.next.next.val, 1);
        Assert.Equal(ptr.next.next.val, 0);
    }
}