using Tumbleweed.Boolean.From.Enumerable.FromSystem;
using Boolean = Tumbleweed.Boolean;
using Scalar = Tumbleweed.Scalar;
using System = System;
using Double = Tumbleweed.Number.Real.Binary.Precision.Double.System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Binary.Precision.Double.System.Exponent.Is;

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
		new BooleanAtIndex(
			new Double::Bits(@double),
			62)
	)
	{
	}
}