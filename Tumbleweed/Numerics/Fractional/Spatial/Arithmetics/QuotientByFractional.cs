using Tumbleweed.Numerics.Fractional.FromSystem;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Spatial.Arithmetics;

public sealed class QuotientByFractional : SpatialEnvelope<IFractional>
{
	public QuotientByFractional
	(
		ISpatial<IFractional> dividend,
		Single divisor
	) : this
	(
		dividend,
		new FractionalFromSingle(divisor)
	)
	{
	}
	
	public QuotientByFractional
	(
		ISpatial<IFractional> dividend,
		IScalar<Single> divisor
	) : this
	(
		dividend,
		new FractionalFromSingle(divisor)
	)
	{
	}
	
	public QuotientByFractional
	(
		ISpatial<IFractional> dividend,
		Double divisor
	) : this
	(
		dividend,
		new FractionalFromDouble(divisor)
	)
	{
	}
	
	public QuotientByFractional
	(
		ISpatial<IFractional> dividend,
		IScalar<Double> divisor
	) : this
	(
		dividend,
		new FractionalFromDouble(divisor)
	)
	{
	}
	
	public QuotientByFractional
	(
		ISpatial<IFractional> dividend,
		IFractional divisor
	) : base
	(
		new QuotientOfSpatials(
			dividend,
			new UniformWithCoordinate<IFractional>(divisor))
	)
	{
	}
}