using SCG = System.Collections.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Whole.Enumerable;

public sealed class One : Any
{
	public One(SCG::IEnumerable<Stereometry.Vertex.Any> vertices) =>
		Vertices = vertices;

	public SCG::IEnumerable<Stereometry.Vertex.Any> Vertices { get; }
}