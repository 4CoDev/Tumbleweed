using Tumbleweed.Enumerable;

using Tumbleweed.Enumerable.Item.From.Left.By.Length;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Double = Tumbleweed.Number.Real.Binary.Precision.Double.System;

namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Mantissa;

public sealed class Bits : Envelope<Boolean.Any>
{
	public Bits(System::Double @double) : this
	(
		new Scalar::Of.Value<System::Double>(@double)
	)
	{
	}
	
	public Bits(Scalar::Any<System::Double> @double) : base
	(
		new System<Boolean.Any>(
			new Double::Bits(@double),
			new Double::Mantissa.Length())
	)
	{
	}
}