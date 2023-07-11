namespace ConsoleApp2;

public class Node
{
    public int Value { get; set; }
    public Node? RightChild { get; set; }
    public Node? LeftChild { get; set; }

    public Node(int value)
    {
        Value = value;
    }

}
public class BinaryTree
{
    private Node? Root { get; set; }
    public bool IsEmpty => Root == null;
    public void Insert(Node node)
    {
        if (Root is null)
        {
            Root = node;
            return;
        }
        var currentNode = Root;
        while (true)
        {
            if (node.Value < currentNode.Value)
            {
                if (currentNode.LeftChild is null)
                {
                    currentNode.LeftChild = node;
                    break;
                }
                currentNode = currentNode.LeftChild;
            }
            else
            {
                if (currentNode.RightChild is null)
                {
                    currentNode.RightChild = node;
                    break;
                }
                currentNode = currentNode.RightChild;
            }
        }
    }
    public bool Find(Node node)
    {
        if (IsEmpty)
            throw new Exception("Empty Tree");
        var currentNode = Root;
        while (currentNode is not null)
        {
            if (node.Value < currentNode.Value)
                currentNode = currentNode.LeftChild;
            else if (node.Value > currentNode.Value)
                currentNode = currentNode.RightChild;
            else
                return true;
        }
        return false;
    }

    private int Height(Node root)
    {
        if (IsEmpty)
            return -1;
        if (root.LeftChild == null && root.RightChild == null)
            return 0;
        if ((root.LeftChild == null && root.RightChild != null) || (root.LeftChild != null && root.RightChild == null))
            return 1;
        return 1 + Math.Max(Height(root.LeftChild), Height(root.RightChild));
    }

    public int Height()
    {
        return Height(Root);
    }

    private bool BalancedTree(Node leftChild,Node rightChild)
    {
        return Math.Abs(Height(leftChild) - Height(rightChild)) <= 1;
    }

    public bool BalancedTree()
    {
        return BalancedTree(Root.LeftChild, Root.RightChild);
    }
}

