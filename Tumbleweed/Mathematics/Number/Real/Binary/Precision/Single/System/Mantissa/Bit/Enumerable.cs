using Tumbleweed.Enumerable.Item.From.Left.By.Length;
using Scalar = Tumbleweed.Scalar.Immutable;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa.Bit;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Boolean.Any>
{
	public Enumerable(System::Single single) : this
	(
		new Scalar::With.Value<System::Single>(single)
	)
	{
	}
	
	public Enumerable
	(
		Scalar::Any<System::Single> single
	) : base
	(
		new System<Boolean.Any>(
			new System.Bit.Enumerable(single),
			new Length())
	)
	{
	}
}