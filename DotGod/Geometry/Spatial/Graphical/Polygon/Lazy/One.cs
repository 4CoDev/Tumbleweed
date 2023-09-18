using Enumerable = DotGod.Geometry.Spatial.Graphical.Vertex.Lazy.Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Polygon.Lazy;

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