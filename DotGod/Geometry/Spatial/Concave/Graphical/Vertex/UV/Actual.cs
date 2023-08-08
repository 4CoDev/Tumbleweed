using Tumbleweed.Point.Planar;
using Tumbleweed.Point.Planar.Function;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex.UV;

public sealed class Actual : Envelope<Tumbleweed.Number.Real.Any>
{
	public Actual(Any vertex) : base
	(
		new Result<Tumbleweed.Number.Real.Any>(() => vertex.UV)
	)
	{
	}
}