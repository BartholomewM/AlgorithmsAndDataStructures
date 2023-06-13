using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructure; 
public abstract class Graph {
	protected List<GraphNode> _nodes;
	protected Dictionary<GraphNode, int> _nodes_dict;

	public Graph() { 
		_nodes = new List<GraphNode>();
		_nodes_dict = new Dictionary<GraphNode, int>();
	}


	//insertVertex(vertex)    - wstawia do grafu węzeł podany węzeł
	public abstract void InsertVertex(GraphNode vertex);

	//insertEdge(vertex1, vertex2, egde) - wstawia do grafu krawędź pomiędzy podane węzły
	public abstract void InsertEdge(GraphNode vertex1, GraphNode vertex2, GraphEdge egde);

	public abstract void InsertTwoWayEdge(GraphNode vertex1, GraphNode vertex2, GraphEdge egde);

	//deleteVertex(vertex) - usuwa podany węzeł
	public abstract void DeleteVertex(GraphNode vertex);

	//deleteEdge(vertex1, vertex2) - usuwa krawędź pomiędzy podanymi węzłami
	public abstract void DeleteEdge(GraphNode vertex1, GraphNode vertex2);

	public abstract void DeleteTwoWayEdge(GraphNode vertex1, GraphNode vertex2);


	//getVertexIdx(vertex) - zwraca indeks węzła(wykorzystując wspomniany słownik)
	public abstract int GetVertexIdx(GraphNode vertex);


	//getVertex(vertex_idx) - zwraca węzeł o podanym indeksie(niejako odwrotność powyższej metody)
	public abstract GraphNode GetVertex(int vertex_idx);


	//neighbours(vertex_idx) - zwraca listę indeksów węzłów przyległych do węzła o podanym indeksie(połączenia wyjściowe)
	public abstract List<int> Neighbours(int vertex_idx);

	//order() - zwraca rząd grafu(liczbę węzłów)
	public abstract int Order();


	//size() - zwraca rozmiar grafu(liczbę krawędzi)
	public abstract int Size();

	// zwracająca wszystkie krawędzie grafu w postaci listy par: (klucz_węzła_początkowego, klucz_węzła_końcowego)
	public abstract List<Tuple<char, char>> Edges();

	protected void _updateNodesDict() {
		var curr_node = _nodes[0];

		for (int i = 0; i < _nodes.Count; i++) {
			curr_node = _nodes[i];
			_nodes_dict[curr_node] = i;
		}
	}
}
