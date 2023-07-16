using System.Text;

namespace OrgTreeCreator;

public class NaryNode<T>
{
    public T Value { get; }
    public List<NaryNode<T>> Children { get; }

    public NaryNode(T value)
    {
        Value = value;
        Children = new List<NaryNode<T>>();
    }

    public void AddChild(NaryNode<T> childNode)
    {
        Children.Add(childNode);
    }

    public override string ToString()
    {
        return ToString("");
    }

    public string ToString(string spaces)
    {
        var sb = new StringBuilder($"{spaces}{Value}:\n");
        foreach (NaryNode<T> child in Children)
        {
            sb.Append(child.ToString(spaces + "  "));
        }
        return sb.ToString();
    }
}