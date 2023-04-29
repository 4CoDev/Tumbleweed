using Tumbleweed.Numerics.Fractional.FromSystem;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Spatial;

public sealed class UniformWithCoordinate :
	SpatialEnvelope<IFractional>
{
	public UniformWithCoordinate
	(
		Single coordinate
	) : this
	(
		new FractionalFromSingle(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate
	(
		IScalar<Single> coordinate
	) : this
	(
		new FractionalFromSingle(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate
	(
		Double coordinate
	) : this
	(
		new FractionalFromDouble(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate
	(
		IScalar<Double> coordinate
	) : this
	(
		new FractionalFromDouble(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate(IFractional coordinate) : base
	(
		new SpatialWithCoordinates(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}