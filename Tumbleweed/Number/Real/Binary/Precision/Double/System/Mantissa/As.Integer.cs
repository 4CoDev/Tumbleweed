using Integer = Tumbleweed.Number.Integer;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Mantissa = Tumbleweed.Number.Real.Binary.Precision.Double.System.Mantissa;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Mantissa.As;

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
			new Mantissa::Is.Positive(@double),
			new Mantissa::As.Natural(@double))
	)
	{
	}
}