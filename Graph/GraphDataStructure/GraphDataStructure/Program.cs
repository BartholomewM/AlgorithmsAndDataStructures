//// See https://aka.ms/new-console-template for more information

using GraphDataStructure;

//vertices = [Vertex('Z'), Vertex('G'), Vertex('N'), Vertex('B'),
//			Vertex('F'), Vertex('P'), Vertex('C'), Vertex('E'),
//			Vertex('W'), Vertex('L'), Vertex('D'), Vertex('O'),
//			Vertex('S'), Vertex('T'), Vertex('K'), Vertex('R')]

//edges = [('Z', 'G'), ('Z', 'P'), ('Z', 'F'),
//			('G', 'Z'), ('G', 'P'), ('G', 'C'), ('G', 'N'),
//			('N', 'G'), ('N', 'C'), ('N', 'W'), ('N', 'B'),
//			('B', 'N'), ('B', 'W'), ('B', 'L'),
//			('F', 'Z'), ('F', 'P'), ('F', 'D'),
//			('P', 'F'), ('P', 'Z'), ('P', 'G'), ('P', 'C'), ('P', 'E'), ('P', 'O'), ('P', 'D'),
//			('C', 'P'), ('C', 'G'), ('C', 'N'), ('C', 'W'), ('C', 'E'),
//			('E', 'P'), ('E', 'C'), ('E', 'W'), ('E', 'T'), ('E', 'S'), ('E', 'O'),
//			('W', 'C'), ('W', 'N'), ('W', 'B'), ('W', 'L'), ('W', 'T'), ('W', 'E'),
//			('L', 'W'), ('L', 'B'), ('L', 'R'), ('L', 'T'),
//			('D', 'F'), ('D', 'P'), ('D', 'O'),
//			('O', 'D'), ('O', 'P'), ('O', 'E'), ('O', 'S'),
//			('S', 'O'), ('S', 'E'), ('S', 'T'), ('S', 'K'),
//			('T', 'S'), ('T', 'E'), ('T', 'W'), ('T', 'L'), ('T', 'R'), ('T', 'K'),
//			('K', 'S'), ('K', 'T'), ('K', 'R'),
//			('R', 'K'), ('R', 'T'), ('R', 'L')]

var nodes = new List<GraphNode>() { new GraphNode('Z'), new GraphNode('G'), new GraphNode('N'), new GraphNode('B'),
			new GraphNode('F'), new GraphNode('P'), new GraphNode('C'), new GraphNode('E'),
			new GraphNode('W'), new GraphNode('L'), new GraphNode('D'), new GraphNode('O'),
			new GraphNode('S'), new GraphNode('T'), new GraphNode('K'), new GraphNode('R')
};

var lst_init = new List<(char, char)> { ('Z', 'G'), ('Z', 'P'), ('Z', 'F'),
			('G', 'Z'), ('G', 'P'), ('G', 'C'), ('G', 'N'),
			('N', 'G'), ('N', 'C'), ('N', 'W'), ('N', 'B'),
			('B', 'N'), ('B', 'W'), ('B', 'L'),
			('F', 'Z'), ('F', 'P'), ('F', 'D'),
			('P', 'F'), ('P', 'Z'), ('P', 'G'), ('P', 'C'), ('P', 'E'), ('P', 'O'), ('P', 'D'),
			('C', 'P'), ('C', 'G'), ('C', 'N'), ('C', 'W'), ('C', 'E'),
			('E', 'P'), ('E', 'C'), ('E', 'W'), ('E', 'T'), ('E', 'S'), ('E', 'O'),
			('W', 'C'), ('W', 'N'), ('W', 'B'), ('W', 'L'), ('W', 'T'), ('W', 'E'),
			('L', 'W'), ('L', 'B'), ('L', 'R'), ('L', 'T'),
			('D', 'F'), ('D', 'P'), ('D', 'O'),
			('O', 'D'), ('O', 'P'), ('O', 'E'), ('O', 'S'),
			('S', 'O'), ('S', 'E'), ('S', 'T'), ('S', 'K'),
			('T', 'S'), ('T', 'E'), ('T', 'W'), ('T', 'L'), ('T', 'R'), ('T', 'K'),
			('K', 'S'), ('K', 'T'), ('K', 'R'),
			('R', 'K'), ('R', 'T'), ('R', 'L')};


var graph = new ListGraph();

foreach (var n in nodes) {
	graph.InsertVertex(n);
}


foreach (var tup in lst_init) {
	graph.InsertTwoWayEdge(new GraphNode(tup.Item1), new GraphNode(tup.Item2), new GraphEdge());
}

graph.PrintDictionary();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


graph.DeleteVertex(new GraphNode('K'));
graph.DeleteEdge(new GraphNode('W'), new GraphNode('E'));

graph.PrintDictionary();

//0 : [1, 4, 5]
//1 : [0, 2, 5, 6]
//2 : [1, 3, 6, 8]
//3 : [2, 8, 9]
//4 : [0, 5, 10]

//5 : [0, 1, 4, 6, 7, 10, 11]
//6 : [1, 2, 5, 7, 8]
//7 : [5, 6, 11, 12, 13]
//8 : [2, 3, 6, 9, 13]

//9 : [3, 8, 13, 14]
//10 : [4, 5, 11]
//11 : [5, 7, 10, 12]
//12 : [7, 11, 13]
//13 : [7, 8, 9, 12, 14]
//14 : [9, 13]



//var d1 = new Dictionary<int, List<int>>();
//var keys1 = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};

//var v0 = new List<int>() { 1, 4, 5 };
//var v1 = new List<int>() { 0, 2, 5, 6 };
//var v2 = new List<int>() { 1, 3, 6, 8 };
//var v3 = new List<int>() { 2, 8, 9 };

//var v4 = new List<int>() { 0, 5, 10 };
//var v5 = new List<int>() { 0, 1, 4, 6, 7, 10, 11 };
//var v6 = new List<int>() { 1, 2, 5, 7, 8 };
//var v7 = new List<int>() { 5, 6, 11, 12, 13 };

//var v8 = new List<int>() { 2, 3, 6, 9, 13 };
//var v9 = new List<int>() { 3, 8, 13, 14 };
//var v10 = new List<int>() { 4, 5, 11 };
//var v11 = new List<int>() { 5, 7, 10, 12 };

//var v12 = new List<int>() { 7, 11, 13 };
//var v13 = new List<int>() { 7, 8, 9, 12, 14 };
//var v14 = new List<int>() { 9, 13 };

//var vals = new List<List<int>>() { v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14 };


//foreach (var k in keys1) {
//	d1[k] = vals[k];
//}


//PrintDictionary(d1);


//void PrintDictionary(Dictionary<int, List<int>> dd) {
//	var keys = new List<int>();
//	var values = new List<int>();
//	string line = "";

//	foreach (var kvp in dd) {
//		line = $"{kvp.Key} : [";

//		foreach (var it in dd[kvp.Key]) {
//			line += $"{it}, ";
//		}

//		line += "]";
//		Console.WriteLine(line);
//	}
//}



//var g1 = new GraphNode('A');
//var g2 = new GraphNode('A');

//Console.WriteLine(g1 == g2);