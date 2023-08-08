using Tumbleweed.Point.Spatial;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex.Normal;

public sealed class Lazy : Envelope<Tumbleweed.Number.Real.Any>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Point.Spatial.Lazy<Tumbleweed.Number.Real.Any>(
			new Actual(vertex))
	)
	{
	}
}