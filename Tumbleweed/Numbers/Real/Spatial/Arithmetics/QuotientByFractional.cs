using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class QuotientByFractional : SpatialEnvelope<IReal>
{
	public QuotientByFractional
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
	
	public QuotientByFractional
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
	
	public QuotientByFractional
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
	
	public QuotientByFractional
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
	
	public QuotientByFractional
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