using Real = Tumbleweed.Number.Real;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Double = Tumbleweed.Number.Real.Binary.Precision.Double.System;
using Binary = Tumbleweed.Number.Real.Binary;

namespace Tumbleweed.Number.Real.Binary.Precision.Double.From.System;

public sealed class One : Real::Envelope
{
	public One(System::Double @double) : this
	(
		new Scalar::Of.Value<System::Double>(@double)
	)
	{
	}

	public One(Scalar::Any<System::Double> @double) : base
	(
		new Real::With.Members(
			new Double.System.Mantissa.As.Integer(@double),
			new Binary::Base.As.Integer(),
			new Double::Exponent.Integer(@double))
	)
	{
	}
}