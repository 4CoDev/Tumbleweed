using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Natural = Tumbleweed.Number.Natural;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Double = Tumbleweed.Number.Real.Binary.Precision.Double.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Mantissa.As;

public sealed class Natural : Natural::Envelope
{
	public Natural
	(
		System::Double @double
	) : this
	(
		new Value<System::Double>(@double)
	)
	{
	}
	
	public Natural
	(
		Any<System::Double> @double
	) : base
	(
		new Natural::With.Bits.New(
			new Double::Bits(@double))
	)
	{
	}
}
