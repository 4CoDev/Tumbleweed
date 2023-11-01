using Tumbleweed.Enumerable.Item.From.Left.By.Length;
using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa.Bit;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Boolean.Any>
{
	public Enumerable(System::Single single) : this
	(
		new Property::With.Value<System::Single>(single)
	)
	{
	}
	
	public Enumerable
	(
		Property::Any<System::Single> single
	) : base
	(
		new System<Boolean.Any>(
			new System.Bit.Enumerable(single),
			new Length())
	)
	{
	}
}