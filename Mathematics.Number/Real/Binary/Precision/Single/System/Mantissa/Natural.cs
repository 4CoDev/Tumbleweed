using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using System = System;
using Property = Tumbleweed.Property.Output;
using Mantissa = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

public sealed class Natural : Number.Natural.Envelope
{
	public Natural(System::Single single) : this
	(
		new Property::With.Value.One<System::Single>(single)
	)
	{
	}
	
	public Natural(Any<System::Single> single) : base
	(
		new Natural::With.Bits.New(
			new Mantissa::Bit.Enumerable(single))
	)
	{
	}
}