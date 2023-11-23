using Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Distance;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Actual = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Point.B.Actual;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Size.Whole;

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