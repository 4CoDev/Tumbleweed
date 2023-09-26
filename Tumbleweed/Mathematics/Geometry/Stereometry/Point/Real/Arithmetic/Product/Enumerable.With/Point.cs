using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Product.Scalar.With.Point;
using Tumbleweed.Mathematics.Number.Real;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Product.Enumerable.With;

public sealed class Point :
	Enumerable::Envelope<Any<Any>>
{
	public Point
	(
		SCG::IEnumerable<Any<Any>> multiplicands,
		Any<Any> multiplier
	) : base
	(
		new Enumerable::Selected
		<Any<Any>>
		(
			multiplicands,
			multiplicand => Expression(multiplicand, multiplier)
		)
	)
	{
	}
	
	private static Any<Any> Expression
	(
		Any<Any> multiplicand,
		Any<Any> multiplier
	) =>
	(
		new Multiple(
			multiplicand,
			multiplier)
	);
}