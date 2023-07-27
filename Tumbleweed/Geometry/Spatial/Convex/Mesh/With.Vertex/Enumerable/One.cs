using Mesh = Tumbleweed.Geometry.Spatial.Convex.Mesh;
using SCG = System.Collections.Generic;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Convex.Mesh.With.Vertex.Enumerable;

public sealed class One : Mesh::Any
{
	public One(SCG::IEnumerable<Vertex::Any> vertices) =>
		Vertices = vertices;

	public SCG::IEnumerable<Vertex::Any> Vertices { get; }
}