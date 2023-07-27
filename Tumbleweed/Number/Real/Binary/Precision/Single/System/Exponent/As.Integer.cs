using Integer = Tumbleweed.Number.Integer;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Exponent = Tumbleweed.Number.Real.Binary.Precision.Single.System.Exponent;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Single.System.Exponent.As;

public sealed class Integer : Integer::Envelope
{
	public Integer(System::Single single) : this
	(
		new Scalar::Of.Value<System::Single>(single)
	)
	{
	}
	
	public Integer(Scalar::Any<System::Single> single) : base
	(
		new Integer::With.Members(
			new Exponent::Is.Positive(single),
			new Exponent::As.Natural(single))
	)
	{
	}
}