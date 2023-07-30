using Tumbleweed.Enumerable.Item.From.Left.By.Length;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Double = Tumbleweed.Number.Real.Binary.Precision.Double.System;

namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Mantissa;

public sealed class Bits : Enumerable.Envelope<Boolean.Any>
{
	public Bits(System::Double @double) : this
	(
		new Value<System::Double>(@double)
	)
	{
	}
	
	public Bits(Any<System::Double> @double) : base
	(
		new System<Boolean.Any>(
			new Double::Bits(@double),
			new Double::Mantissa.Length())
	)
	{
	}
}