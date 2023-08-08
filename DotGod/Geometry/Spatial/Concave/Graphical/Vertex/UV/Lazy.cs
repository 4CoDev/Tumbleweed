using Tumbleweed.Point.Planar;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex.UV;

public sealed class Lazy : Envelope<Tumbleweed.Number.Real.Any>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Point.Planar.Lazy<Tumbleweed.Number.Real.Any>(
			new Actual(vertex))
	)
	{
	}
}