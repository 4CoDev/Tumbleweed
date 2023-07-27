using Polygon = Tumbleweed.Geometry.Spatial.Concave.Polygon;
using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Concave.Polygon.With.Vertex.Enumerable;

public sealed class One : Polygon::Any
{
	public One(SCG::IEnumerable<Vertex::Any> vertices) =>
		Vertices = vertices;
	
	public SCG::IEnumerable<Vertex::Any> Vertices { get; }
}