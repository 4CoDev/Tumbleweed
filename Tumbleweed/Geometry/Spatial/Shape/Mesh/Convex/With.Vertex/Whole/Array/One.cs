using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.With.Vertex.Whole.Array;

public sealed class One : Envelope
{
	public One(params Vertex::Any[] vertices) : base
	(
		new Enumerable.One(vertices)
	)
	{
	}
}