using Tumbleweed.Boolean.From.Enumerable.FromSystem;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Exponent.Is;

public sealed class Positive : Boolean.Envelope
{
	public Positive(System::Single single) : this
	(
		new Scalar::Of.Value<System::Single>(single)
	)
	{
	}
	
	public Positive(Scalar::Any<System::Single> single) : base
	(
		new BooleanAtIndex(
			new Single::Bits(single),
			30)
	)
	{
	}
}