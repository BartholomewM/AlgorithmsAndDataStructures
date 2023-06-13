using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructure; 
public class ListGraph : Graph {
	//specifies connections
	private Dictionary<int, List<Tuple<int, GraphEdge>>> _adj_lst;

	public List<GraphNode> Nodes { get => _nodes; }
	public Dictionary<GraphNode, int> NodesDict { get => _nodes_dict; }
	public Dictionary<int, List<Tuple<int, GraphEdge>>> AdjacentList { get => _adj_lst; }


	public ListGraph() { 
		_adj_lst = new Dictionary<int, List<Tuple<int, GraphEdge>>>();
	}


	private void _sortDict() {
		throw new NotImplementedException();
	}
	

	public override void InsertVertex(GraphNode vertex) {
		if (!_nodes.Contains(vertex)) {
			int idx = Order();
			_nodes.Add(vertex);
			_nodes_dict[vertex] = idx;
			_adj_lst[idx] = new List<Tuple<int, GraphEdge>>();
		}
	}


	public override void DeleteVertex(GraphNode vertex) {
		if (_nodes.Count == 0) return;

		int idx = GetVertexIdx(vertex);
		_adj_lst?.Remove(idx);

		var keys = _adj_lst?.Keys.ToList();

		if ( (_adj_lst?.Count ?? 0) == 0 ) return;

		for (int i = 0; i < keys!.Count; i++) {
			//vals = ;
			_adj_lst![keys[i]].RemoveAll(tup => tup.Item1 == idx);
		}

		_nodes.Remove(vertex);
		_nodes_dict.Remove(vertex);

		_updateNodesDict();
		_updateAdjList(idx);
	}


	private void _updateAdjList(int idx) {
		var keys = _adj_lst.Keys.ToList();
		var count = keys.Count;
		var key = keys[0];

		List < Tuple<int, GraphEdge> >? nextLst = null;
		List<Tuple<int, GraphEdge>>? currLst = null;

		for (int i = 0; i < count; i++) {
			key = keys[i];
			currLst = _adj_lst[key];
			nextLst = new List<Tuple<int, GraphEdge>>();

			for (int j = 0; j < currLst.Count; j++) {
				if (currLst[j].Item1 > idx) {
					nextLst.Add(new Tuple<int, GraphEdge>(currLst[j].Item1-1, currLst[j].Item2));
				}
				else {
					nextLst.Add(currLst[j]);
				}
			}

			if (key > idx) {
				_adj_lst.Remove(key);
				_adj_lst[key - 1] = nextLst;
			}
			else {
				_adj_lst[key] = nextLst;
			}
		}
	}


	public override void InsertEdge(GraphNode vertex1, GraphNode vertex2, GraphEdge edge) {
		// inserts checks if vertex is already in graph
		InsertVertex(vertex1);
		InsertVertex(vertex2);

		var idx1 = GetVertexIdx(vertex1);
		var idx2 = GetVertexIdx(vertex2);
		var edgeInfo = new Tuple<int, GraphEdge> (idx2, edge);

		_adj_lst?[idx1].Add(edgeInfo);
		_adj_lst?[idx1].Sort( (tup1, tup2) => tup1.Item1.CompareTo(tup2.Item1) );
	}


	public override void InsertTwoWayEdge(GraphNode vertex1, GraphNode vertex2, GraphEdge edge) {
		// inserts checks if vertex is already in graph
		InsertVertex(vertex1);
		InsertVertex(vertex2);

		var idx1 = GetVertexIdx(vertex1);
		var idx2 = GetVertexIdx(vertex2);
		var edgeInfo1 = new Tuple<int, GraphEdge>(idx2, edge);
		var edgeInfo2 = new Tuple<int, GraphEdge>(idx1, edge);

		_adj_lst?[idx1].Add(edgeInfo1);
		_adj_lst![idx1] = _adj_lst![idx1].DistinctBy(tup => tup.Item1).ToList();
		_adj_lst?[idx1].Sort((tup1, tup2) => tup1.Item1.CompareTo(tup2.Item1));


		_adj_lst?[idx2].Add(edgeInfo2);
		_adj_lst![idx2] = _adj_lst![idx2].DistinctBy( tup => tup.Item1 ).ToList();
		_adj_lst?[idx2].Sort((tup1, tup2) => tup1.Item1.CompareTo(tup2.Item1));
	}


	public override void DeleteEdge(GraphNode vertex1, GraphNode vertex2) {
		var idx1 = GetVertexIdx(vertex1);
		var idx2 = GetVertexIdx(vertex2);

		_adj_lst[idx1].RemoveAll((kvp) => { return kvp.Item1 == idx2; });
		_adj_lst[idx2].RemoveAll((kvp) => { return kvp.Item1 == idx1; });
	}


	public override void DeleteTwoWayEdge(GraphNode vertex1, GraphNode vertex2) {
		var idx1 = GetVertexIdx(vertex1);
		var idx2 = GetVertexIdx(vertex2);

		_adj_lst[idx1].RemoveAll((kvp) => { return kvp.Item1 == idx2; });
		_adj_lst[idx2].RemoveAll((kvp) => { return kvp.Item1 == idx1; });
	}


	/// <summary>
	/// return index from dictionar in abstract class Graph
	/// </summary>
	/// <param name="vertex"></param>
	/// <returns></returns>
	public override int GetVertexIdx(GraphNode vertex) => _nodes_dict[vertex];


	public override GraphNode GetVertex(int vertex_idx) => _nodes[vertex_idx];


	public override List<int> Neighbours(int vertex_idx) {
		var tup_lst = _adj_lst[vertex_idx];
		var neighbours = new List<int>();

		foreach (var tup in tup_lst) {
			neighbours.Add(tup.Item1);
		}

		return neighbours;
	}


	public override int Order() => _nodes.Count;


	public override int Size() {
		throw new NotImplementedException();
	}


	public override List<Tuple<char, char>> Edges() {
		var edges = new List<Tuple<char, char>>();


		throw new NotImplementedException();
	}


	public void PrintDictionary() {
		var keys = new List<int>();
		var values = new List<int>();
		string line = "";

		foreach(var kvp in _adj_lst) {
			line = $"{kvp.Key} : [";

			foreach (var tup in _adj_lst[kvp.Key]) {
				line += $"{tup.Item1}, ";
			}

			line += "]";
			Console.WriteLine(line);
		}
	}
}
