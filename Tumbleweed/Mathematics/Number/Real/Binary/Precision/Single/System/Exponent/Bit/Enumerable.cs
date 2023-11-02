using Enumerable = Tumbleweed.Enumerable;
using Boolean = Tumbleweed.Mathematics.Boolean;
using System = System;
using Property = Tumbleweed.Property;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent.Bit;

public sealed class Enumerable : Enumerable::Envelope<Boolean::Any>
{
	public Enumerable(System::Single single) : this
	(
		new Property::Output.With.Value.One
			<System::Single>
			(single)
	)
	{
	}
	
	public Enumerable
	(
		Property::Output.Any<System::Single> single
	) : base
	(
		new Enumerable::Slice.In.Range.System
		<Boolean.Any>
		(
			new System.Bit.Enumerable(single),
			23,
			30
		)
	)
	{
	}
}