using Tumbleweed.Mathematics.Geometry.Planimetry.Point;
using Tumbleweed.Mathematics.Geometry.Planimetry.Point.Function.Result;
using Tumbleweed.Point.Planar;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.UV;

public sealed class Actual : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Actual(Any vertex) : base
	(
		new Actual<Tumbleweed.Mathematics.Number.Real.Any>(() => vertex.UV)
	)
	{
	}
}