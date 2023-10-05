using Tumbleweed.Enumerable.With.Length.Statement;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon.Triangle.With.Vertex.Enumerable;

public sealed class One : Envelope
{
	public One(IEnumerable<Graphical.Vertex.Any> vertices) : base
	(
		new Polygon.With.Vertex.Enumerable.One(
			new System<Graphical.Vertex.Any>(vertices, 3))
	)
	{
	}
}