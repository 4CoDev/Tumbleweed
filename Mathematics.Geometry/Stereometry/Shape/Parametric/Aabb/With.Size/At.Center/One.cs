using Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Quotient.Scalar.With.Number;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.With.Size.At.Center;

public sealed class One : Any
{
	public One(Any<Mathematics.Number.Real.Any> size) =>
		half = new Real(size, 2);

	public Any<Mathematics.Number.Real.Any> A =>
		new Arithmetic.Vector.Spatial.Real.Negation.Of.One(half);
	
	public Any<Mathematics.Number.Real.Any> B => half;

	private readonly Any<Mathematics.Number.Real.Any> half;
}