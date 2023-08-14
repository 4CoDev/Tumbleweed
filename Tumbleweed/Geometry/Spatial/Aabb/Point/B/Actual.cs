using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace Tumbleweed.Geometry.Spatial.Aabb.Point.B;

public sealed class Actual : Envelope<Tumbleweed.Number.Real.Any>
{
	public Actual
	(
		Any occupation
	) : base
	(
		new Result<Tumbleweed.Number.Real.Any>(
			() => occupation.B)
	)
	{
	}
}