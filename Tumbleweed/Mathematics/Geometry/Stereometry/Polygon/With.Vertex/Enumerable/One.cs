using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Polygon.With.Vertex.Enumerable;

public sealed class One : Any
{
	public One(SCG::IEnumerable<Stereometry.Vertex.Any> vertices) =>
		Vertices = vertices;
	
	public SCG::IEnumerable<Stereometry.Vertex.Any> Vertices { get; }
}