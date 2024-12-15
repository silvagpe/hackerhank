
using System.ComponentModel;

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
    private ListNode GetListNode(){
        return null;
    }

    [Fact]
    public void ReverseList()
    {
        var head = GetListNode();

        if (head.next == null)
        {
            return;
        }

    }
}