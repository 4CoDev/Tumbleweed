using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Function.Result;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.A;

public sealed class Actual : Envelope<Mathematics.Number.Real.Any>
{
	public Actual
	(
		Any space
	) : base
	(
		new Actual<Mathematics.Number.Real.Any>(
			() => space.A)
	)
	{
	}
}