using Tumbleweed.Boolean.From.Enumerable.FromSystem;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
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
		new Value<System::Single>(single)
	)
	{
	}
	
	public Positive(Any<System::Single> single) : base
	(
		new BooleanAtIndex(
			new Single::Bits(single),
			30)
	)
	{
	}
}