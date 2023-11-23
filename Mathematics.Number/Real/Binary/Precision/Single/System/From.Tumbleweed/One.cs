using Property = Tumbleweed.Property.Output;
using System = System;
using Single = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed;

public sealed class One : Property::Envelope<System::Single>
{
	public One(Any real) : base
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