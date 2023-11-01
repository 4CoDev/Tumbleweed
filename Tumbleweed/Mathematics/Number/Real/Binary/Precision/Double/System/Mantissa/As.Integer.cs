using Tumbleweed.Mathematics.Number.Integer;
using Tumbleweed.Mathematics.Number.Integer.With.Member;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With;
using Integer = Tumbleweed.Mathematics.Number.Integer;
using System = System;
using Property = Tumbleweed.Property;
using Mantissa = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Mantissa;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Mantissa.As;

public sealed class Integer : Number.Integer.Envelope
{
	public Integer(System::Double @double) : this
	(
		new Value<System::Double>(@double)
	)
	{
	}

	public Integer(Any<System::Double> @double) : base
	(
		new Definition(
			new Mantissa::Is.Positive(@double),
			new Mantissa::As.Natural(@double))
	)
	{
	}
}