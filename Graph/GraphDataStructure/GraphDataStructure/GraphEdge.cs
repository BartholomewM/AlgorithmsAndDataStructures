using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructure; 
public class GraphEdge {
	// weight
	private int _capacity;
	private int? _flow = null;
	private int? _residual = null;
	private bool _isResidual = false;
	//private bool _is_only_weighted;

	public GraphEdge(int capacity=1, int? flow=null, int? residual=null, bool isResidual=false, bool isOnlyWeighted=true) {
		if (isOnlyWeighted) {
			_capacity = capacity;
		}
		else {
			_capacity = capacity;
			_flow = flow;
			_residual = residual;
			_isResidual = isResidual;
		}
	}

}
