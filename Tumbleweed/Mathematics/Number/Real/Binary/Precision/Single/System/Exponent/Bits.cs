using Enumerable = Tumbleweed.Enumerable;
using Boolean = Tumbleweed.Mathematics.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent;

public sealed class Bits : Enumerable::Envelope<Boolean::Any>
{
	public Bits(System::Single single) : this
	(
		new Scalar::Immutable.With.Value
			<System::Single>
			(single)
	)
	{
	}
	
	public Bits
	(
		Scalar::Immutable.Any<System::Single> single
	) : base
	(
		new Enumerable::Item.From.Middle.By.Indents.System
		<Boolean.Any>
		(
			new System.Bits(single),
			23,
			30
		)
	)
	{
	}
}