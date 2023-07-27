using Integer = Tumbleweed.Number.Integer;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Exponent = Tumbleweed.Number.Real.Binary.Precision.Double.System.Exponent;

namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Exponent;

public sealed class Integer : Integer::Envelope
{
	public Integer(System::Double @double) : this
	(
		new Scalar::Of.Value<System::Double>(@double)
	)
	{
	}
	
	public Integer(Scalar::Any<System::Double> @double) : base
	(
		new Integer::With.Members(
			new Exponent::Is.Positive(@double),
			new Exponent::Natural(@double))
	)
	{
	}
}