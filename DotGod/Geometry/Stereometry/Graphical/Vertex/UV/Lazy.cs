using Tumbleweed.Mathematics.Geometry.Planimetry.Point;
using Tumbleweed.Point.Planar;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.UV;

public sealed class Lazy : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Mathematics.Geometry.Planimetry.Point.Lazy<Tumbleweed.Mathematics.Number.Real.Any>(
			new Actual(vertex))
	)
	{
	}
}