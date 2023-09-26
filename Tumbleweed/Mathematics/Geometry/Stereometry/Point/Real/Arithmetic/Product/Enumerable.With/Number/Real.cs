using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Product.Enumerable.With.Number;

public sealed class Real :
	Enumerable::Envelope<Any<Any>>
{
	public Real
	(
		SCG::IEnumerable<Any<Any>> multiplicands,
		Any multiplier
	) : base
	(
		new Point(
			multiplicands,
			new Uniform(multiplier))
	)
	{
	}
}