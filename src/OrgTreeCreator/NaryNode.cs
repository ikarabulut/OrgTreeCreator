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
        var nodeFamilyString = $"{Value}: ";
        foreach (NaryNode<T> child in Children)
        {
            nodeFamilyString += $"{child.Value} ";
        }

        return nodeFamilyString;
    }
}