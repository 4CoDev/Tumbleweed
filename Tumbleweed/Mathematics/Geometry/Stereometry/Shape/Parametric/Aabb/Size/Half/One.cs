using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Quotient.Scalar.With.Number;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Size.Half;

public sealed class One : Envelope<Mathematics.Number.Real.Any>
{
	public One(Any space) : base
	(
		new Real(
			new Whole.One(space), 2)
	)
	{
	}
}