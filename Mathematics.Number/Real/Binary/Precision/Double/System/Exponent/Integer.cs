using Tumbleweed.Mathematics.Number.Integer.With.Member;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;
using Integer = Tumbleweed.Mathematics.Number.Integer;
using System = System;
using Exponent = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Exponent;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Exponent;

public sealed class Integer : Number.Integer.Envelope
{
	public Integer(System::Double @double) : this
	(
		new One<System::Double>(@double)
	)
	{
	}
	
	public Integer(Any<System::Double> @double) : base
	(
		new Definition(
			new Exponent::Is.Positive(@double),
			new Natural(@double))
	)
	{
	}
}