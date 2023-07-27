using Natural = Tumbleweed.Number.Natural;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Exponent = Tumbleweed.Number.Real.Binary.Precision.Single.System.Exponent;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Exponent.As;

public sealed class Natural : Natural::Envelope
{
	public Natural(System::Single single) : this
	(
		new Scalar::Of.Value<global::System.Single>(single)
	)
	{
	}
	
	public Natural(Scalar::Any<System::Single> single) : base
	(
		new Natural::With.Bits.New(
			new Exponent::Bits(single))
	)
	{
	}
}