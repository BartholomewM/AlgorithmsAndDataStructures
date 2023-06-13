using GraphDataStructure;


namespace TestGraph; 
[TestClass]
public class TestListGraph {
	[TestMethod]
	public void TestInsertVertex() {
		var graph = new ListGraph();
		var chars = new char[] { 'A', 'B', 'C', 'D' };
		var nodes = graph.Nodes;


		foreach ( char c in chars )
			graph.InsertVertex(new GraphNode(c));

		for ( int i = 0; i < chars.Length; i++ )
			Assert.AreEqual(chars[i], nodes[i].Key);

		for (int i = 0; i < chars.Length; i++)
			Assert.AreEqual(i, graph.NodesDict[nodes[i]]);
	}

	[TestMethod]
	public void TestInsertEdge() {

	}
}