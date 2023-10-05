using Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Sum.Scalar.Of;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Sum.Enumerable.With.Point;

public sealed class Real : Enumerable::Envelope<Any<Any>>
{
	public Real
	(
		SCG::IEnumerable<Any<Any>> augends,
		Any<Any> addend
	) : base
	(
		new Enumerable::Selected<Any<Any>>(
			augends,
			augend => new Multiple(augend, addend))
	)
	{
	}
}