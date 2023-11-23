using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Product.Enumerable.With.Number;

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