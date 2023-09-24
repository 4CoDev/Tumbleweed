using Tumbleweed.Mathematics.Boolean.From.Enumerable.FromSystem;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Boolean = Tumbleweed.Boolean;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Double = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.System.Exponent.Is;

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
		new BooleanAtIndex(
			new Bits(@double),
			62)
	)
	{
	}
}