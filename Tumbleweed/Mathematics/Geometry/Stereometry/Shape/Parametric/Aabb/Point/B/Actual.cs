using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Function.Result;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.B;

public sealed class Actual : Envelope<Mathematics.Number.Real.Any>
{
	public Actual
	(
		Any occupation
	) : base
	(
		new Actual<Mathematics.Number.Real.Any>(
			() => occupation.B)
	)
	{
	}
}