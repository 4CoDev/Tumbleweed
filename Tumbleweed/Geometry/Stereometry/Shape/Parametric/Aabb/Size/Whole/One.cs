using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Distance;
using Actual = Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Point.B.Actual;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Size.Whole;

public sealed class One : Envelope<Mathematics.Number.Real.Any>
{
	public One(Any space) : base
	(
		new L1(
			new Point.A.Actual(space),
			new Actual(space))
	)
	{
	}
}