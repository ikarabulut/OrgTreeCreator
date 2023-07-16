using System.Text;

using OrgTreeCreator;

using Xunit.Abstractions;

namespace OrgTreeCreatorTests;

public class BinaryNodeTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public BinaryNodeTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

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
    public void ToString_OnRoot_ShouldReturnEntireTree()
    {
        var rootNodeValue = "Root";
        var rootLeftChildValue = "A";
        var rootRightChildValue = "B";
        var leftChildSubLeftChildValue = "C";
        var leftChildSubRightChildValue = "D";
        var rightChildSubLeftChildValue = "E";
        var rootBinaryNode = new BinaryNode<string>(rootNodeValue);
        var rootRightChildNode = new BinaryNode<string>(rootRightChildValue);
        var rootLeftChildNode = new BinaryNode<string>(rootLeftChildValue);
        var leftChildSubLeftNode = new BinaryNode<string>(leftChildSubLeftChildValue);
        var leftChildSubRightNode = new BinaryNode<string>(leftChildSubRightChildValue);
        var rightChildSubRightChildRightNode = new BinaryNode<string>(rightChildSubLeftChildValue);
        rootBinaryNode.AddLeft(rootLeftChildNode);
        rootBinaryNode.AddRight(rootRightChildNode);
        rootLeftChildNode.AddLeft(leftChildSubLeftNode);
        rootLeftChildNode.AddRight(leftChildSubRightNode);
        leftChildSubRightNode.AddRight(rightChildSubRightChildRightNode);

        const string indent = "  ";
        var expectedTreeString = new StringBuilder();
        expectedTreeString.AppendLine($"{rootNodeValue}:");
        expectedTreeString.AppendLine($"{indent}{rootLeftChildValue}:");
        expectedTreeString.AppendLine($"{indent}{indent}{leftChildSubLeftChildValue}:");
        expectedTreeString.AppendLine($"{indent}{indent}{leftChildSubRightChildValue}:");
        expectedTreeString.AppendLine($"{indent}{indent}{indent}None");
        expectedTreeString.AppendLine($"{indent}{indent}{indent}{rightChildSubLeftChildValue}:");
        expectedTreeString.AppendLine($"{indent}{rootRightChildValue}:");

        Assert.Equal(expectedTreeString.ToString(), rootBinaryNode.ToString());
    }

    [Fact]
    public void ToString_OnLeftChild_ShouldReturnLeftChildTree()
    {
        var rootNodeValue = "Root";
        var rootLeftChildValue = "A";
        var rootRightChildValue = "B";
        var leftChildSubLeftChildValue = "C";
        var leftChildSubRightChildValue = "D";
        var rightChildSubLeftChildValue = "E";
        var rootBinaryNode = new BinaryNode<string>(rootNodeValue);
        var rootRightChildNode = new BinaryNode<string>(rootRightChildValue);
        var rootLeftChildNode = new BinaryNode<string>(rootLeftChildValue);
        var leftChildSubLeftNode = new BinaryNode<string>(leftChildSubLeftChildValue);
        var leftChildSubRightNode = new BinaryNode<string>(leftChildSubRightChildValue);
        var rightChildSubRightChildRightNode = new BinaryNode<string>(rightChildSubLeftChildValue);
        rootBinaryNode.AddLeft(rootLeftChildNode);
        rootBinaryNode.AddRight(rootRightChildNode);
        rootLeftChildNode.AddLeft(leftChildSubLeftNode);
        rootLeftChildNode.AddRight(leftChildSubRightNode);
        leftChildSubRightNode.AddRight(rightChildSubRightChildRightNode);

        const string indent = "  ";
        var expectedLeftChildTreeString = new StringBuilder();
        expectedLeftChildTreeString.AppendLine($"{rootLeftChildValue}:");
        expectedLeftChildTreeString.AppendLine($"{indent}{leftChildSubLeftChildValue}:");
        expectedLeftChildTreeString.AppendLine($"{indent}{leftChildSubRightChildValue}:");
        expectedLeftChildTreeString.AppendLine($"{indent}{indent}None");
        expectedLeftChildTreeString.AppendLine($"{indent}{indent}{rightChildSubLeftChildValue}:");

        Assert.Equal(expectedLeftChildTreeString.ToString(), rootLeftChildNode.ToString());
    }


}