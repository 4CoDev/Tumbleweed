using Tumbleweed.Mathematics.Number.Integer;
using Tumbleweed.Mathematics.Number.Integer.With.Member;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Integer = Tumbleweed.Mathematics.Number.Integer;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Exponent = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Exponent.As;

public sealed class Integer : Number.Integer.Envelope
{
	public Integer(System::Single single) : this
	(
		new Value<System::Single>(single)
	)
	{
	}
	
	public Integer(Any<System::Single> single) : base
	(
		new Definition(
			new Exponent::Is.Positive(single),
			new Exponent::As.Natural(single))
	)
	{
	}
}