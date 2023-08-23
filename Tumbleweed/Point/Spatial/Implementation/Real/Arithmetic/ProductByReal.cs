using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial.With.Coordinates;
using One = Tumbleweed.Number.Real.Binary.Precision.Double.From.System.One;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Arithmetic;

public sealed class ProductByReal : Envelope<Any>
{
	public ProductByReal
	(
		Any<Any> point,
		Single single
	) : this
	(
		point,
		new Number.Real.Binary.Precision.Single.From.System.One(single)
	)
	{
	}
	
	public ProductByReal
	(
		Any<Any> point, Tumbleweed.Scalar.Immutable.Any<Single> single
	) : this
	(
		point,
		new Number.Real.Binary.Precision.Single.From.System.One(single)
	)
	{
	}
	
	public ProductByReal
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
	
	public ProductByReal
	(
		Any<Any> point, Tumbleweed.Scalar.Immutable.Any<Double> @double
	) : this
	(
		point,
		new One(@double)
	)
	{
	}
	
	public ProductByReal
	(
		Any<Any> point,
		Any real
	) : base
	(
		new QuotientOfPoints(
			point,
			new Uniform<Any>(real))
	)
	{
	}
}