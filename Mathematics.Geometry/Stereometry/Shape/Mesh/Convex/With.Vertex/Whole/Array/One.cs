namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Whole.Array;

public sealed class One : Envelope
{
	public One(params Stereometry.Vertex.Any[] vertices) : base
	(
		new Enumerable.One(vertices)
	)
	{
	}
}