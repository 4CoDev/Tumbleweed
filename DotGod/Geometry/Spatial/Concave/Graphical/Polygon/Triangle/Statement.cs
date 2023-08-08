using DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Triangle.With.Vertex.Enumerable;
using DotGod.Geometry.Spatial.Concave.Graphical.Vertex;
using Tumbleweed.Enumerable.Function;
using Vertex = DotGod.Geometry.Spatial.Concave.Graphical.Vertex;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Triangle;

public sealed class Statement : Envelope
{
	public Statement(Any polygon) : base
	(
		new One(
			new Result<Vertex::Any>(
				() => polygon.Vertices))
	)
	{
	}
}