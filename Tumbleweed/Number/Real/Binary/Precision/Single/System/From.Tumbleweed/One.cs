using Tumbleweed.Scalar.Immutable;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Real = Tumbleweed.Number.Real;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single.System;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;

public sealed class One : Envelope<System::Single>
{
	public One(Real::Any real) : base
	(
		new Single::From.Bits(
			new Enumerable::Concatenated<Boolean.Any>(
				real.Mantissa.Natural.Bits,
				real.Exponent.Natural.Bits,
				new Enumerable::From.Array<Boolean.Any>(
					real.Exponent.IsPositive,
					real.Mantissa.IsPositive)))
	)
	{
	}

}