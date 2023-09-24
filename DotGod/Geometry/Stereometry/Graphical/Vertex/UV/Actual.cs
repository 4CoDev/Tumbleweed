using Tumbleweed.Point.Planar;
using Tumbleweed.Point.Planar.Function;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.UV;

public sealed class Actual : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Actual(Any vertex) : base
	(
		new Result<Tumbleweed.Mathematics.Number.Real.Any>(() => vertex.UV)
	)
	{
	}
}