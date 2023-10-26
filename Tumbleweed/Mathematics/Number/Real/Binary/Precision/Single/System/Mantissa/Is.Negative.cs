using Boolean = Tumbleweed.Mathematics.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using Single = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa.Is;

public sealed class Negative : Boolean::Envelope
{
	public Negative(System::Single single) : this
	(
		new Scalar::With.Value<System::Single>(single)
	)
	{
	}
	
	public Negative
	(
		Scalar::Any<System::Single> single
	) : base
	(
		new Boolean::From.Enumerable.Last(
			new System.Bit.Enumerable(single))
	)
	{
	}
}