using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructure; 
public class MatrixGraph : Graph {
	private List<List<int>> _adj_matrix;

	public MatrixGraph() : base() { 
		_adj_matrix = new List<List<int>>();
	}

	public override void DeleteEdge(GraphNode vertex1, GraphNode vertex2) {
		throw new NotImplementedException();
	}

	public override void DeleteTwoWayEdge(GraphNode vertex1, GraphNode vertex2) {
		throw new NotImplementedException();
	}

	public override void DeleteVertex(GraphNode vertex) {
		throw new NotImplementedException();
	}

	public override List<Tuple<char, char>> Edges() {
		throw new NotImplementedException();
	}

	public override GraphNode GetVertex(int vertex_idx) {
		throw new NotImplementedException();
	}

	public override int GetVertexIdx(GraphNode vertex) {
		throw new NotImplementedException();
	}

	public override void InsertEdge(GraphNode vertex1, GraphNode vertex2, GraphEdge egde) {
		throw new NotImplementedException();
	}

	public override void InsertTwoWayEdge(GraphNode vertex1, GraphNode vertex2, GraphEdge egde) {
		throw new NotImplementedException();
	}

	public override void InsertVertex(GraphNode vertex) {
		throw new NotImplementedException();
	}

	public override List<int> Neighbours(int vertex_idx) {
		throw new NotImplementedException();
	}

	public override int Order() {
		throw new NotImplementedException();
	}

	public override int Size() {
		throw new NotImplementedException();
	}
}
