using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Quotient.Scalar.With.Number;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.With.Size.At.Center;

public sealed class One : Any
{
	public One(Any<Mathematics.Number.Real.Any> size) =>
		half = new Real(size, 2);

	public Any<Mathematics.Number.Real.Any> A =>
		new Stereometry.Point.Real.Arithmetic.Negation.Of.One(half);
	
	public Any<Mathematics.Number.Real.Any> B => half;

	private readonly Any<Mathematics.Number.Real.Any> half;
}