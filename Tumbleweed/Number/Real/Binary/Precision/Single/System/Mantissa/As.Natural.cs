using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Natural = Tumbleweed.Number.Natural;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Mantissa = Tumbleweed.Number.Real.Binary.Precision.Single.System.Mantissa;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Mantissa.As;

public sealed class Natural : Natural::Envelope
{
	public Natural(System::Single single) : this
	(
		new Value<System::Single>(single)
	)
	{
	}
	
	public Natural(Any<System::Single> single) : base
	(
		new Natural::With.Bits.New(
			new Mantissa::Bits(single))
	)
	{
	}
}