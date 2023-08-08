using DotGod.Geometry.Spatial.Concave.Graphical.Polygon.With.Vertex.Enumerable;
using Tumbleweed.Enumerable.With.Length.Statement;
using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Triangle.With.Vertex.Enumerable;

public sealed class One : Envelope
{
	public One(IEnumerable<Vertex::Any> vertices) : base
	(
		new Polygon.With.Vertex.Enumerable.One(
			new System<Vertex::Any>(vertices, 3))
	)
	{
	}
}