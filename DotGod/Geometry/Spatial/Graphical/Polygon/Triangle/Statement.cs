using DotGod.Geometry.Spatial.Graphical.Polygon.Triangle.With.Vertex.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Geometry.Spatial.Graphical.Polygon.Triangle;

public sealed class Statement : Envelope
{
	public Statement(Any polygon) : base
	(
		new One(
			new Result<Graphical.Vertex.Any>(
				() => polygon.Vertices))
	)
	{
	}
}