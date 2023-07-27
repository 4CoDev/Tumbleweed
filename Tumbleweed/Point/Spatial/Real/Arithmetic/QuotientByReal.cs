using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Double.From.System;
using Tumbleweed.Point.Spatial.With.Coordinates;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.Real.Arithmetic;

public sealed class QuotientByReal : Envelope<Any>
{
	public QuotientByReal
	(
		Any<Any> dividend,
		Single divisor
	) : this
	(
		dividend,
		new Number.Real.Binary.Precision.Single.From.System.One(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		Any<Any> dividend, Scalar::Any<Single> divisor
	) : this
	(
		dividend,
		new Number.Real.Binary.Precision.Single.From.System.One(divisor)
	)
	{
	}
	
	public QuotientByReal
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
	
	public QuotientByReal
	(
		Any<Any> dividend, Scalar::Any<Double> divisor
	) : this
	(
		dividend,
		new One(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		Any<Any> dividend,
		Any divisor
	) : base
	(
		new QuotientOfPoints(
			dividend,
			new Uniform<Any>(divisor))
	)
	{
	}
}