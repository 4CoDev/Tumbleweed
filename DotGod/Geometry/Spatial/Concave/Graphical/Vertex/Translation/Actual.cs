using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex.Translation;

public sealed class Actual : Envelope<Tumbleweed.Number.Real.Any>
{
	public Actual(Any vertex) : base
	(
		new Result<Tumbleweed.Number.Real.Any>(
			() => vertex.Translation)
	)
	{
	}
}