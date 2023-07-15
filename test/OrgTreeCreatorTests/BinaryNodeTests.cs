using OrgTreeCreator;

namespace OrgTreeCreatorTests;

public class BinaryNodeTests
{
    [Fact]
    public void AddLeft_OnRootNode_ShouldSetLeftChildToPassedNode()
    {
        var nodeValue = "Root";
        var rootBinaryNode = new BinaryNode<string>(nodeValue);
        var leftChildNodeValue = "A";
        var leftChildNode = new BinaryNode<string>(leftChildNodeValue);

        rootBinaryNode.AddLeft(leftChildNode);

        Assert.Equal(rootBinaryNode.LeftChild, leftChildNode);
    }

    [Fact]
    public void AddRight_OnRootNode_ShouldSetRightChildToPassedNode()
    {
        var nodeValue = "Root";
        var rootBinaryNode = new BinaryNode<string>(nodeValue);
        var rightChildNodeValue = "B";
        var rightChildNode = new BinaryNode<string>(rightChildNodeValue);

        rootBinaryNode.AddRight(rightChildNode);

        Assert.Equal(rootBinaryNode.RightChild, rightChildNode);
    }


}