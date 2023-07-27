using Tumbleweed.Enumerable;

using Tumbleweed.Enumerable.Item.From.Left.By.Length;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single.System;

namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Mantissa;

public sealed class Bits : Envelope<Boolean.Any>
{
	public Bits(System::Single single) : this
	(
		new Scalar::Of.Value<System::Single>(single)
	)
	{
	}
	
	public Bits(Scalar::Any<System::Single> single) : base
	(
		new System<Boolean.Any>(
			new Single::Bits(single),
			new Single::Mantissa.Length())
	)
	{
	}
}