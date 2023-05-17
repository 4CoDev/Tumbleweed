using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class ProductByReal : SpatialEnvelope<IReal>
{
	public ProductByReal
	(
		ISpatial<IReal> spatial,
		Single single
	) : this
	(
		spatial,
		new RealFromSingle(single)
	)
	{
	}
	
	public ProductByReal
	(
		ISpatial<IReal> spatial,
		IScalar<Single> single
	) : this
	(
		spatial,
		new RealFromSingle(single)
	)
	{
	}
	
	public ProductByReal
	(
		ISpatial<IReal> spatial,
		Double @double
	) : this
	(
		spatial,
		new RealFromDouble(@double)
	)
	{
	}
	
	public ProductByReal
	(
		ISpatial<IReal> spatial,
		IScalar<Double> @double
	) : this
	(
		spatial,
		new RealFromDouble(@double)
	)
	{
	}
	
	public ProductByReal
	(
		ISpatial<IReal> spatial,
		IReal real
	) : base
	(
		new QuotientOfSpatials(
			spatial,
			new UniformWithCoordinate<IReal>(real))
	)
	{
	}
}