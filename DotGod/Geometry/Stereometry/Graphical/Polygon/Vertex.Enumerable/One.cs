using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Geometry.Stereometry.Graphical.Polygon.Vertex.Enumerable;

public sealed class One : Envelope<Graphical.Vertex.Any>
{
	public One(Any polygon) : base
	(
		new Result<Graphical.Vertex.Any>(
			() => polygon.Vertices)
	)
	{
	}
}