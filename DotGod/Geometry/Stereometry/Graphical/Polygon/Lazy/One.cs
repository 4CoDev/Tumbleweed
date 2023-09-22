using Enumerable = DotGod.Geometry.Stereometry.Graphical.Vertex.Lazy.Enumerable;

namespace DotGod.Geometry.Stereometry.Graphical.Polygon.Lazy;

public sealed class One : Envelope
{
	public One(Any polygon) : base
	(
		new With.Vertex.Enumerable.One(
			new Enumerable(
				new Vertex.Enumerable.One(polygon)))
	)
	{
	}
}