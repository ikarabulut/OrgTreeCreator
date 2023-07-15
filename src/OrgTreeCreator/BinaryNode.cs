namespace OrgTreeCreator;

public class BinaryNode<T>
{
    public T Value { get; }
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
        return "";
    }

    public string ToString(string spaces)
    {
        return "";
    }
}