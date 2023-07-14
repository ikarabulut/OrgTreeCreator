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

    [Fact]
    public void ToString_OnRootNode_AndBothChildNodes_ShouldDisplayEachChildNodeValue()
    {
        var nodeValue = "Root";
        var rootBinaryNode = new BinaryNode<string>(nodeValue);
        var leftChildNodeValue = "A";
        var rightChildNodeValue = "B";
        var leftChildNode = new BinaryNode<string>(leftChildNodeValue);
        var rightChildNode = new BinaryNode<string>(rightChildNodeValue);

        rootBinaryNode.AddLeft(leftChildNode);
        rootBinaryNode.AddRight(rightChildNode);

        var expectedToString = $"{nodeValue}: {leftChildNode.Value} {rightChildNode.Value}";
        Assert.Equal(expectedToString, rootBinaryNode.ToString());
    }

    [Fact]
    public void ToString_OnNodeWithBothChildren_ShouldDisplayEachChildsValue()
    {
        var nodeValue = "A";
        var binaryNode = new BinaryNode<string>(nodeValue);
        var leftChildNodeValue = "C";
        var rightChildNodeValue = "D";
        var leftChildNode = new BinaryNode<string>(leftChildNodeValue);
        var rightChildNode = new BinaryNode<string>(rightChildNodeValue);

        binaryNode.AddLeft(leftChildNode);
        binaryNode.AddRight(rightChildNode);

        var expectedToString = $"{nodeValue}: {leftChildNode.Value} {rightChildNode.Value}";
        Assert.Equal(expectedToString, binaryNode.ToString());
    }

    [Fact]
    public void ToString_OnNodeWithNoChildren_ShouldDisplayNullForEachChild()
    {
        var nodeValue = "A";
        var binaryNode = new BinaryNode<string>(nodeValue);

        var expectedToString = $"{nodeValue}: null null";
        Assert.Equal(expectedToString, binaryNode.ToString());
    }

    [Fact]
    public void ToString_OnNodeWithOnlyLeftChild_ShouldDisplayLeftValueAndNull()
    {
        var nodeValue = "A";
        var binaryNode = new BinaryNode<string>(nodeValue);
        var leftChildNodeValue = "C";
        var leftChildNode = new BinaryNode<string>(leftChildNodeValue);

        binaryNode.AddLeft(leftChildNode);

        var expectedToString = $"{nodeValue}: {leftChildNode.Value} null";
        Assert.Equal(expectedToString, binaryNode.ToString());
    }
}