using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Integer = Tumbleweed.Number.Integer;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Mantissa = Tumbleweed.Number.Real.Binary.Precision.Single.System.Mantissa;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Mantissa.As;

public sealed class Integer : Integer::Envelope
{
	public Integer(System::Single single) : this
	(
		new Value<System::Single>(single)
	)
	{
	}
	
	public Integer(Any<System::Single> single) : base
	(
		new Integer::With.Members(
			new Mantissa::Is.Positive(single),
			new Mantissa::As.Natural(single))
	)
	{
	}
}