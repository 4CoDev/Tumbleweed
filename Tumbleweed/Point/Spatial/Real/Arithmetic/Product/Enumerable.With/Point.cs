using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Product.Enumerable.With;

public sealed class Point :
	Enumerable::Envelope<Point::Generic.Any<Real::Any>>
{
	public Point
	(
		SCG::IEnumerable<Point::Generic.Any<Real::Any>> multiplicands,
		Point::Generic.Any<Real::Any> multiplier
	) : base
	(
		new Enumerable::Selected
		<Point::Generic.Any<Real::Any>>
		(
			multiplicands,
			multiplicand => Expression(multiplicand, multiplier)
		)
	)
	{
	}
	
	private static Point::Generic.Any<Real::Any> Expression
	(
		Point::Generic.Any<Real::Any> multiplicand,
		Point::Generic.Any<Real::Any> multiplier
	) =>
	(
		new Point::Real.Arithmetic.Product.Scalar.With.Point.Multiple(
			multiplicand,
			multiplier)
	);
}