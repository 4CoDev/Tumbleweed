using Tumbleweed.Enumerable.Item.From.Middle.By.Indents;
using Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Exponent;

public sealed class Bits : Enumerable.Envelope<Boolean.Any>
{
	public Bits(Any<System::Double> @double) : base
	(
		new System<Boolean.Any>(
			new System.Bits(@double),
			52,
			61)
	)
	{
	}
}