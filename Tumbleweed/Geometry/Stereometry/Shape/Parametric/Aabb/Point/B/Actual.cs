using Tumbleweed.Point.Spatial.Function;
using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Point.B;

public sealed class Actual : Envelope<Mathematics.Number.Real.Any>
{
	public Actual
	(
		Any occupation
	) : base
	(
		new Result<Mathematics.Number.Real.Any>(
			() => occupation.B)
	)
	{
	}
}