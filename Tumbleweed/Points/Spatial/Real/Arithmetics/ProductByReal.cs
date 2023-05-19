using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial.Real.Arithmetics;

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