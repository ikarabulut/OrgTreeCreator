using System.Reflection.Metadata.Ecma335;

using OrgTreeCreator;

namespace OrgTreeCreatorTests;

public class NaryNodeTests
{
    [Fact]
    public void AddChild_WhenParentHasNoChildren_ShouldAddPassedChild()
    {
        const string rootNaryValue = "root";
        var rootNaryNode = new NaryNode<string>(rootNaryValue);
        const string childNaryNodeValue = "a";
        var rootNaryChild1 = new NaryNode<string>(childNaryNodeValue);

        rootNaryNode.AddChild(rootNaryChild1);

        Assert.Contains(rootNaryChild1, rootNaryNode.Children);
    }

    [Fact]
    public void AddChild_WhenParentHas1Child_ShouldHaveBothChildren()
    {
        const string rootNaryValue = "root";
        var rootNaryNode = new NaryNode<string>(rootNaryValue);
        const string childNaryNodeValue = "a";
        const string childNaryNode2Value = "b";
        var rootNaryChild1 = new NaryNode<string>(childNaryNodeValue);
        var rootNaryChild2 = new NaryNode<string>(childNaryNode2Value);
        rootNaryNode.AddChild(rootNaryChild1);
        rootNaryNode.AddChild(rootNaryChild2);

        Assert.Contains(rootNaryChild1, rootNaryNode.Children);
        Assert.Contains(rootNaryChild2, rootNaryNode.Children);
    }
}