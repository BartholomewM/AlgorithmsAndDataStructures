using GraphDataStructure;

namespace TestGraph;

[TestClass]
public class TestGraphNode {
	[TestMethod]
	public void TestNodeCreation() {
		var node1 = new GraphNode('H');

		Assert.IsNotNull(node1);
		Assert.AreEqual('H', node1.Key);
		Assert.AreNotEqual('h', node1.Key);
		Console.WriteLine(node1);
	}

	[TestMethod]
	public void TestNodeEquall() {
		var node1 = new GraphNode('H');
		var node2 = new GraphNode('H');

		Assert.IsNotNull(node1);
		Assert.IsNotNull(node2);

		Assert.AreEqual(true, node1.Equals(node2));
		Assert.AreEqual(true, node2.Equals(node1));
		Assert.AreEqual(true, node2 ==  node1);
	}
}
