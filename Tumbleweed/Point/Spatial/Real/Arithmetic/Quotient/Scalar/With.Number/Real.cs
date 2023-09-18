using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Double.From.System;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Tumbleweed.Point.Spatial.Real.Arithmetic.Quotient.Scalar.Of.Point;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic.Quotient.Scalar.With.Number;

public sealed class Real : Envelope<Any>
{
	public Real
	(
		Any<Any> dividend,
		Single divisor
	) : this
	(
		dividend,
		new Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One(divisor)
	)
	{
	}
	
	public Real
	(
		Any<Any> dividend, Tumbleweed.Scalar.Immutable.Any<Single> divisor
	) : this
	(
		dividend,
		new Tumbleweed.Number.Real.Binary.Precision.Single.From.System.One(divisor)
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
		new One(divisor)
	)
	{
	}
	
	public Real
	(
		Any<Any> dividend, Tumbleweed.Scalar.Immutable.Any<Double> divisor
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