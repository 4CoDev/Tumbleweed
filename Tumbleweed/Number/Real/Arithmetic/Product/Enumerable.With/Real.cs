using Tumbleweed.Number.Real.Arithmetic.Product.Scalar.Of;
using Enumerable = Tumbleweed.Enumerable;
using Real = Tumbleweed.Number.Real;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Number.Real.Arithmetic.Product.Enumerable.With;

public sealed class Real : Enumerable::Envelope<Real::Any>
{
	public Real
	(
		SCG::IEnumerable<Real::Any> multiplicands,
		Real::Any multiplier
	) : base
	(
		new Enumerable::Selected<Real::Any>(
			multiplicands,
			multiplicand => Expression(multiplicand, multiplier))
	)
	{
	}

	private static Real::Any Expression
	(
		Real::Any multiplicand,
		Real::Any multiplier
	) =>
	(
		new Multiple(
			multiplicand,
			multiplier)
	);
}