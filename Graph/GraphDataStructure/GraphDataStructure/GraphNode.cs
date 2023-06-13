using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructure; 
public class GraphNode {
	private char _key;

	public char Key { get => _key; }

	public GraphNode(char key) {
		_key = key;
	}

	public static bool operator ==(GraphNode left, GraphNode right) => left.Key == right.Key;

	public static bool operator !=(GraphNode left, GraphNode right) => left.Key != right.Key;

	public override bool Equals(object? obj) {
		if ( (obj == null) || !(GetType().Equals( obj.GetType() )) ) {
			return false;
		} 
		else {
			GraphNode n = (GraphNode) obj;

			return _key == n.Key;
		}
	}

	public override int GetHashCode() {
		return _key.GetHashCode();
	}

	public override string ToString() => $"Graph({_key})";
}
