using Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Quotient.Scalar.With.Number;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

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