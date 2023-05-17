using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class QuotientByReal : SpatialEnvelope<IReal>
{
	public QuotientByReal
	(
		ISpatial<IReal> dividend,
		Single divisor
	) : this
	(
		dividend,
		new RealFromSingle(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		ISpatial<IReal> dividend,
		IScalar<Single> divisor
	) : this
	(
		dividend,
		new RealFromSingle(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		ISpatial<IReal> dividend,
		Double divisor
	) : this
	(
		dividend,
		new RealFromDouble(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		ISpatial<IReal> dividend,
		IScalar<Double> divisor
	) : this
	(
		dividend,
		new RealFromDouble(divisor)
	)
	{
	}
	
	public QuotientByReal
	(
		ISpatial<IReal> dividend,
		IReal divisor
	) : base
	(
		new QuotientOfSpatials(
			dividend,
			new UniformWithCoordinate<IReal>(divisor))
	)
	{
	}
}