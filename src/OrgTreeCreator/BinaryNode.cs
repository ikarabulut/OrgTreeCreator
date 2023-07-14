namespace OrgTreeCreator;

public class BinaryNode<T>
{
    private T Value { get; set; }
    public BinaryNode<T>? LeftChild { get; private set; }
    public BinaryNode<T>? RightChild { get; private set; }

    public BinaryNode(T value)
    {
        Value = value;
        LeftChild = null;
        RightChild = null;
    }

    public void AddLeft(BinaryNode<T> leftChild)
    {
        LeftChild = leftChild;
    }

    public void AddRight(BinaryNode<T> rightChild)
    {
        RightChild = rightChild;
    }

    public override string ToString()
    {
        return $"{Value}: {LeftChild} {RightChild}";
    }
}