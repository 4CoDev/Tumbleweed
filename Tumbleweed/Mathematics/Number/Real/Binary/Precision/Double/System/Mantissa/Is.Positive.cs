using Tumbleweed.Mathematics.Boolean.From.Enumerable;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

using System = System;
using Scalar = Tumbleweed.Scalar;
using Double = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Mantissa.Is;

public sealed class Positive : Boolean.Envelope
{
	public Positive(System::Double @double) : this
	(
		new Value<System::Double>(@double)
	)
	{
	}
	
	public Positive(Any<System::Double> @double) : base
	(
		new Last(
			new Bits(@double))
	)
	{
	}
}