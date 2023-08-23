using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Double.From.System;
using Tumbleweed.Point.Spatial.With.Coordinates;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Arithmetic;

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
		Any<Any> dividend, Tumbleweed.Scalar.Immutable.Any<Single> divisor
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
		Any<Any> dividend, Tumbleweed.Scalar.Immutable.Any<Double> divisor
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