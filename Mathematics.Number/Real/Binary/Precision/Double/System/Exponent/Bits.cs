using Enumerable = Tumbleweed.Enumerable;
using Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Exponent;

public sealed class Bits : Enumerable::Envelope<Boolean.Any>
{
	public Bits(Any<System::Double> @double) : base
	(
		new Enumerable::Slice.In.Range.System<Boolean.Any>(
			new System.Bits(@double),
			52,
			62)
	)
	{
	}
}