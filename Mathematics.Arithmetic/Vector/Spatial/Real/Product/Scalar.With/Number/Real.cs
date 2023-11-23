using Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Quotient.Scalar.Of.Point;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;
using One = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Double.From.System.One;

namespace Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Product.Scalar.With.Number;

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
		Any<Any> point, Tumbleweed.Property.Output.Any<Single> single
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
		Any<Any> point, Tumbleweed.Property.Output.Any<Double> @double
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