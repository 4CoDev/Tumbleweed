using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Polygon.With.Vertex.Enumerable;

public sealed class One : Any
{
	public One(SCG::IEnumerable<Vertex::Any> vertices) =>
		Vertices = vertices;
	
	public SCG::IEnumerable<Vertex::Any> Vertices { get; }
}