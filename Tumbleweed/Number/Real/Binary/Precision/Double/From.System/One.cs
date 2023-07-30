using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
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
		new Value<System::Double>(@double)
	)
	{
	}

	public One(Any<System::Double> @double) : base
	(
		new Real::With.Members(
			new Double.System.Mantissa.As.Integer(@double),
			new Binary::Base.As.Integer(),
			new Double::Exponent.Integer(@double))
	)
	{
	}
}