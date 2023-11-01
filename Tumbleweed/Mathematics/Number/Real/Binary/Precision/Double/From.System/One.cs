using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;
using Real = Tumbleweed.Mathematics.Number.Real;
using System = System;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.From.System;

public sealed class One : Envelope
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
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Mantissa.As.Integer(@double),
			new Base.As.Integer(),
			new Double.System.Exponent.Integer(@double))
	)
	{
	}
}