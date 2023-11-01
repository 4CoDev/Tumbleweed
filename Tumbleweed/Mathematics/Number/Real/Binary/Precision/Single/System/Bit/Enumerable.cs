using Property = Tumbleweed.Property;
using Tumbleweed.Mathematics.Boolean;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Bit;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Boolean.Any>
{
	public Enumerable(System::Single single) : this
	(
		new Property::Output.With.Value
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
		new BitsOfBytes(
			new Byte.Enumerable(single))
	)
	{
	}
}