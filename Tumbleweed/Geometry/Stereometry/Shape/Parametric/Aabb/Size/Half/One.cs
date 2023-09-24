using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Quotient.Scalar.With.Number;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Size.Half;

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