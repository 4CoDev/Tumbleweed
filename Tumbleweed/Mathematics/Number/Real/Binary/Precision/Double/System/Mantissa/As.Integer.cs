using Tumbleweed.Mathematics.Number.Integer;
using Tumbleweed.Mathematics.Number.Integer.With.Member;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Integer = Tumbleweed.Mathematics.Number.Integer;
using System = System;
using Scalar = Tumbleweed.Scalar;
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