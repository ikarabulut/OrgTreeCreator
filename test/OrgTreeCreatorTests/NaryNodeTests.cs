using System.Text;

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

    [Fact]
    public void ToString_OnRoot_ShouldShowEntireTree()
    {
        const string rootNaryValue = "root";
        var rootNaryNode = new NaryNode<string>(rootNaryValue);
        const string childNaryNodeValue = "a";
        const string childNaryNode2Value = "b";
        const string childNaryNode3Value = "c";
        const string childNaryNode2Child1Value = "d";
        const string childNaryNode2Child2Value = "e";

        var rootNaryChild1 = new NaryNode<string>(childNaryNodeValue);
        var rootNaryChild2 = new NaryNode<string>(childNaryNode2Value);
        var rootNaryChild3 = new NaryNode<string>(childNaryNode3Value);
        var childNaryChild2Child1 = new NaryNode<string>(childNaryNode2Child1Value);
        var childNaryChild2Child2 = new NaryNode<string>(childNaryNode2Child2Value);

        rootNaryNode.AddChild(rootNaryChild1);
        rootNaryNode.AddChild(rootNaryChild2);
        rootNaryNode.AddChild(rootNaryChild3);
        rootNaryChild2.AddChild(childNaryChild2Child1);
        rootNaryChild2.AddChild(childNaryChild2Child2);

        const string indent = "  ";
        var expectedRootNaryTree = new StringBuilder();
        expectedRootNaryTree.AppendLine($"{rootNaryValue}:");
        expectedRootNaryTree.AppendLine($"{indent}{childNaryNodeValue}:");
        expectedRootNaryTree.AppendLine($"{indent}{childNaryNode2Value}:");
        expectedRootNaryTree.AppendLine($"{indent}{indent}{childNaryNode2Child1Value}:");
        expectedRootNaryTree.AppendLine($"{indent}{indent}{childNaryNode2Child2Value}:");
        expectedRootNaryTree.AppendLine($"{indent}{childNaryNode3Value}:");

        Assert.Equal(expectedRootNaryTree.ToString(), rootNaryNode.ToString());
    }
}