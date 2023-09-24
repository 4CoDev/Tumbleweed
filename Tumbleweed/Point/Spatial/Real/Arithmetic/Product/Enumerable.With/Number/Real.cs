using Tumbleweed.Mathematics.Number.Real;
using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Product.Enumerable.With.Number;

public sealed class Real :
	Enumerable::Envelope<Point::Generic.Any<Any>>
{
	public Real
	(
		SCG::IEnumerable<Point::Generic.Any<Any>> multiplicands,
		Any multiplier
	) : base
	(
		new Point::Real.Arithmetic.Product.Enumerable.With.Point(
			multiplicands,
			new Point::Real.With.Coordinate.Definition.Uniform(multiplier))
	)
	{
	}
}