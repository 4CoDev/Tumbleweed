using Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Product.Scalar.Of;
using Tumbleweed.Mathematics.Number.Real;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Arithmetic.Numerical.Real.Product.Enumerable.With;

public sealed class Real : Enumerable::Envelope<Any>
{
	public Real
	(
		SCG::IEnumerable<Any> multiplicands,
		Any multiplier
	) : base
	(
		new Enumerable::Selected<Any>(
			multiplicands,
			multiplicand => Expression(multiplicand, multiplier))
	)
	{
	}

	private static Any Expression
	(
		Any multiplicand,
		Any multiplier
	) =>
	(
		new Multiple(
			multiplicand,
			multiplier)
	);
}