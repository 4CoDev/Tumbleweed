using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Quotient.Scalar.With.Number;

namespace Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.With.Size.At.Center;

public sealed class One : Any
{
	public One(Any<Tumbleweed.Number.Real.Any> size) =>
		half = new Real(size, 2);

	public Any<Tumbleweed.Number.Real.Any> A =>
		new Tumbleweed.Point.Spatial.Real.Arithmetic.Negation.Of.One(half);
	
	public Any<Tumbleweed.Number.Real.Any> B => half;

	private readonly Any<Tumbleweed.Number.Real.Any> half;
}