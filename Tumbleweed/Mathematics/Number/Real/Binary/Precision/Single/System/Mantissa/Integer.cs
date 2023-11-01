using System = System;
using Property = Tumbleweed.Property.Output;
using Mantissa = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.Mantissa;

public sealed class Integer : Number.Integer.Envelope
{
	public Integer(System::Single single) : this
	(
		new Property::With.Value<System::Single>(single)
	)
	{
	}
	
	public Integer
	(
		Property::Any<System::Single> single
	) : base
	(
		new Number.Integer.With.Member.Definition(
			new Mantissa::Is.Negative(single),
			new Mantissa::Natural(single))
	)
	{
	}
}