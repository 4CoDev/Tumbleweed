using Tumbleweed.Point.Planar;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.UV;

public sealed class Lazy : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Point.Planar.Lazy<Tumbleweed.Mathematics.Number.Real.Any>(
			new Actual(vertex))
	)
	{
	}
}