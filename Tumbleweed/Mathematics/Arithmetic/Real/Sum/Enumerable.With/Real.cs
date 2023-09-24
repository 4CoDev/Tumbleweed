using Tumbleweed.Mathematics.Arithmetic.Real.Sum.Scalar.Of;
using Tumbleweed.Mathematics.Number.Real;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Mathematics.Arithmetic.Real.Sum.Enumerable.With;

public sealed class Real : Enumerable::Envelope<Any>
{
	public Real
	(
		SCG::IEnumerable<Any> augends,
		Any addend
	) : base
	(
		new Enumerable::Selected<Any>(
			augends,
			augend => new Multiple(augend, addend))
	)
	{
	}
}