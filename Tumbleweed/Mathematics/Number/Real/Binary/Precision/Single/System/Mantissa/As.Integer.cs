using Tumbleweed.Mathematics.Number.Integer.With.Member;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;
using System = System;
using Mantissa = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

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
		new Number.Integer.With.Member.Definition(
			new Mantissa::Is.Positive(single),
			new Mantissa::As.Natural(single))
	)
	{
	}
}