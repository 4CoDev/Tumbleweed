using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Exponent;

public sealed class Natural : Number.Natural.Envelope
{
	public Natural(System::Double @double) : this
	(
		new Value<System::Double>(@double)
	)
	{
	}
	
	public Natural(Any<System::Double> @double) : base
	(
		new Natural::With.Bits.New(
			new System.Bits(@double))
	)
	{
	}
}