using Tumbleweed.Boolean.From.Enumerable;
using Boolean = Tumbleweed.Boolean;
using System = System;
using Scalar = Tumbleweed.Scalar;
using Double = Tumbleweed.Number.Real.Binary.Precision.Double.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Mantissa.Is;

public sealed class Positive : Boolean.Envelope
{
	public Positive(System::Double @double) : this
	(
		new Scalar::Of.Value<System::Double>(@double)
	)
	{
	}
	
	public Positive(Scalar::Any<System::Double> @double) : base
	(
		new Last(
			new Double::Bits(@double))
	)
	{
	}
}