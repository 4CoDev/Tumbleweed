using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Distance;
using Actual = Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Point.B.Actual;

namespace Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.Size.Whole;

public sealed class One : Envelope<Tumbleweed.Number.Real.Any>
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