using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Quotient.Scalar.Of.Point;
using Tumbleweed.Mathematics.Number.Real;
using One = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.From.System.One;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Product.Scalar.With.Number;

public sealed class Real : Envelope<Any>
{
	public Real
	(
		Any<Any> point,
		Single single
	) : this
	(
		point,
		new Mathematics.Number.Real.Binary.Precision.Single.From.System.One(single)
	)
	{
	}
	
	public Real
	(
		Any<Any> point, Tumbleweed.Scalar.Immutable.Any<Single> single
	) : this
	(
		point,
		new Mathematics.Number.Real.Binary.Precision.Single.From.System.One(single)
	)
	{
	}
	
	public Real
	(
		Any<Any> point,
		Double @double
	) : this
	(
		point,
		new One(@double)
	)
	{
	}
	
	public Real
	(
		Any<Any> point, Tumbleweed.Scalar.Immutable.Any<Double> @double
	) : this
	(
		point,
		new One(@double)
	)
	{
	}
	
	public Real
	(
		Any<Any> point,
		Any real
	) : base
	(
		new Multiple(
			point,
			new Uniform<Any>(real))
	)
	{
	}
}