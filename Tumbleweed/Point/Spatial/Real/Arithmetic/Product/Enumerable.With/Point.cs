using Tumbleweed.Mathematics.Number.Real;
using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Product.Enumerable.With;

public sealed class Point :
	Enumerable::Envelope<Point::Generic.Any<Any>>
{
	public Point
	(
		SCG::IEnumerable<Point::Generic.Any<Any>> multiplicands,
		Point::Generic.Any<Any> multiplier
	) : base
	(
		new Enumerable::Selected
		<Point::Generic.Any<Any>>
		(
			multiplicands,
			multiplicand => Expression(multiplicand, multiplier)
		)
	)
	{
	}
	
	private static Point::Generic.Any<Any> Expression
	(
		Point::Generic.Any<Any> multiplicand,
		Point::Generic.Any<Any> multiplier
	) =>
	(
		new Point::Real.Arithmetic.Product.Scalar.With.Point.Multiple(
			multiplicand,
			multiplier)
	);
}