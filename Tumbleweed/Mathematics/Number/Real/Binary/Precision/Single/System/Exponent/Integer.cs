using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using Exponent = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent;

public sealed class Integer : Number.Integer.Envelope
{
	public Integer(System::Single single) : this
	(
		new Scalar::With.Value<System::Single>(single)
	)
	{
	}
	
	public Integer(Scalar::Any<System::Single> single) : base
	(
		new Number.Integer.With.Member.Definition(
			new Exponent::Is.Negative(single),
			new Exponent::Natural(single))
	)
	{
	}
}