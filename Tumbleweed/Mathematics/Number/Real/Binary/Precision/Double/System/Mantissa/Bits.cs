using Tumbleweed.Enumerable.Item.From.Left.By.Length;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Mantissa;

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
			new System.Bits(@double),
			new Length())
	)
	{
	}
}