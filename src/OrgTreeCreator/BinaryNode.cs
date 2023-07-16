using System.Text;

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
        return ToString("");
    }

    public string ToString(string spaces)
    {
        var sb = new StringBuilder($"{spaces}{Value}:\n");
        if (LeftChild != null || RightChild != null)
        {
            if (LeftChild == null)
            {
                sb.Append($"{spaces + "  "}None\n");
            }
            else
            {
                sb.Append(LeftChild.ToString(spaces + "  "));
            }

            if (RightChild == null)
            {
                sb.Append($"{spaces + "  "}None\n");
            }
            else
            {
                sb.Append(RightChild.ToString(spaces + "  "));
            }
        }
        return sb.ToString();
    }
}