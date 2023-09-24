using Tumbleweed.Point.Spatial.Function;
using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A;

public sealed class Actual : Envelope<Mathematics.Number.Real.Any>
{
	public Actual
	(
		Any space
	) : base
	(
		new Result<Mathematics.Number.Real.Any>(
			() => space.A)
	)
	{
	}
}