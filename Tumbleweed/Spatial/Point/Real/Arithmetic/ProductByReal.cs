using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Spatial.Point.Real.Arithmetic;

public sealed class ProductByReal : PointEnvelope<IReal>
{
	public ProductByReal
	(
		IPoint<IReal> point,
		Single single
	) : this
	(
		point,
		new RealFromSingle(single)
	)
	{
	}
	
	public ProductByReal
	(
		IPoint<IReal> point,
		IScalar<Single> single
	) : this
	(
		point,
		new RealFromSingle(single)
	)
	{
	}
	
	public ProductByReal
	(
		IPoint<IReal> point,
		Double @double
	) : this
	(
		point,
		new RealFromDouble(@double)
	)
	{
	}
	
	public ProductByReal
	(
		IPoint<IReal> point,
		IScalar<Double> @double
	) : this
	(
		point,
		new RealFromDouble(@double)
	)
	{
	}
	
	public ProductByReal
	(
		IPoint<IReal> point,
		IReal real
	) : base
	(
		new QuotientOfPoints(
			point,
			new UniformWithCoordinate<IReal>(real))
	)
	{
	}
}