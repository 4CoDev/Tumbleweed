using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;
using Multiple = Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Quotient.Scalar.Of.Point.Multiple;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Quotient.Scalar.With.Number;

public sealed class Real : Envelope<Any>
{
	public Real
	(
		Any<Any> dividend,
		Single divisor
	) : this
	(
		dividend,
		new One(divisor)
	)
	{
	}
	
	public Real
	(
		Any<Any> dividend,
		Tumbleweed.Property.Output.Any<Single> divisor
	) : this
	(
		dividend,
		new One(divisor)
	)
	{
	}
	
	public Real
	(
		Any<Any> dividend,
		Double divisor
	) : this
	(
		dividend,
		new Mathematics.Number.Real.Binary.Precision.Double.From.System.One(divisor)
	)
	{
	}
	
	public Real
	(
		Any<Any> dividend,
		Tumbleweed.Property.Output.Any<Double> divisor
	) : this
	(
		dividend,
		new Mathematics.Number.Real.Binary.Precision.Double.From.System.One(divisor)
	)
	{
	}
	
	public Real
	(
		Any<Any> dividend,
		Any divisor
	) : base
	(
		new Multiple(
			dividend,
			new Uniform<Any>(divisor))
	)
	{
	}
}