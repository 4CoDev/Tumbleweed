using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Sum.Scalar.Of;
using Tumbleweed.Mathematics.Number.Real;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Sum.Enumerable.With.Point;

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