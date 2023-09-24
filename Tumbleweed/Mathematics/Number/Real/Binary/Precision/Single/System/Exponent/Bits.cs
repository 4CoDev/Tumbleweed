using Tumbleweed.Enumerable.Item.From.Middle.By.Indents;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent;

public sealed class Bits : Enumerable.Envelope<Boolean.Any>
{
	public Bits(System::Single single) : this
	(
		new Value<System::Single>(single)
	)
	{
	}
	
	public Bits(Any<System::Single> single) : base
	(
		new System<Boolean.Any>(
			new System.Bits(single),
			23,
			29)
	)
	{
	}
}