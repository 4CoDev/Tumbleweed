using Tumbleweed.Enumerable.Item.From.Middle.By.Indents;
using Tumbleweed.Scalar.Immutable;
using Boolean = Tumbleweed.Boolean;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Double = Tumbleweed.Number.Real.Binary.Precision.Double.System;

namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Exponent;

public sealed class Bits : Enumerable.Envelope<Boolean.Any>
{
	public Bits(Any<System::Double> @double) : base
	(
		new System<Boolean.Any>(
			new Double::Bits(@double),
			52,
			61)
	)
	{
	}
}