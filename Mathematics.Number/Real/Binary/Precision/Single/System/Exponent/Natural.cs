using Natural = Tumbleweed.Mathematics.Number.Natural;
using System = System;
using Property = Tumbleweed.Property.Output;
using Enumerable = Tumbleweed.Enumerable;
using Boolean = Tumbleweed.Mathematics.Boolean;
using Exponent = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent;

public sealed class Natural : Number.Natural.Envelope
{
	public Natural(System::Single single) : this
	(
		new Property::With.Value.One<System::Single>(single)
	)
	{
	}
	
	public Natural(Property::Any<System::Single> single) : base
	(
		new Natural::With.Bits.New(
			new Enumerable::Item.From.Left.By.Length.System<Boolean::Any>(
				new Exponent::Bit.Enumerable(single),
				7))
	)
	{
	}
}