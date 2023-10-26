using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using Mantissa = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

public sealed class Natural : Number.Natural.Envelope
{
	public Natural(System::Single single) : this
	(
		new Scalar::With.Value<System::Single>(single)
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