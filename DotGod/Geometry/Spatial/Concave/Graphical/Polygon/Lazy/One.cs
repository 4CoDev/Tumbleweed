using DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Vertex;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Lazy;

public sealed class One : Envelope
{
	public One(Any polygon) : base
	(
		new With.Vertex.Enumerable.One(
			new DotGod.Geometry.Spatial.Concave.Graphical.Vertex.Lazy.Enumerable(
				new Vertex.Enumerable.One(polygon)))
	)
	{
	}
}