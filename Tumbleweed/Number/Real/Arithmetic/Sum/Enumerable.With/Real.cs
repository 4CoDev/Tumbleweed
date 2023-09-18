using Enumerable = Tumbleweed.Enumerable;
using Real = Tumbleweed.Number.Real;
using SCG = System.Collections.Generic;
using Sum = Tumbleweed.Number.Real.Arithmetic.Sum;

namespace Tumbleweed.Number.Real.Arithmetic.Sum.Enumerable.With;

public sealed class Real : Enumerable::Envelope<Real::Any>
{
	public Real
	(
		SCG::IEnumerable<Real::Any> augends,
		Real::Any addend
	) : base
	(
		new Enumerable::Selected<Real::Any>(
			augends,
			augend => new Sum::Scalar.Of.Multiple(augend, addend))
	)
	{
	}
}