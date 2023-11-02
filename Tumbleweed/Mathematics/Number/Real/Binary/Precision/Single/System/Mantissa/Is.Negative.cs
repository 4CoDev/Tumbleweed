using Boolean = Tumbleweed.Mathematics.Boolean;
using System = System;
using Property = Tumbleweed.Property.Output;
using Single = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa.Is;

public sealed class Negative : Boolean::Envelope
{
	public Negative(System::Single single) : this
	(
		new Property::With.Value.One<System::Single>(single)
	)
	{
	}
	
	public Negative
	(
		Property::Any<System::Single> single
	) : base
	(
		new Boolean::From.Enumerable.Last(
			new System.Bit.Enumerable(single))
	)
	{
	}
}