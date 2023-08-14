using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace Tumbleweed.Geometry.Spatial.Aabb.Point.A;

public sealed class Actual : Envelope<Tumbleweed.Number.Real.Any>
{
	public Actual
	(
		Any space
	) : base
	(
		new Result<Tumbleweed.Number.Real.Any>(
			() => space.A)
	)
	{
	}
}