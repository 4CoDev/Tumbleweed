using Tumbleweed.Numbers.Real.FromSystem;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Spatial;

public sealed class UniformWithCoordinate :
	SpatialEnvelope<IReal>
{
	public UniformWithCoordinate
	(
		Single coordinate
	) : this
	(
		new RealFromSingle(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate
	(
		IScalar<Single> coordinate
	) : this
	(
		new RealFromSingle(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate
	(
		Double coordinate
	) : this
	(
		new RealFromDouble(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate
	(
		IScalar<Double> coordinate
	) : this
	(
		new RealFromDouble(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate(IReal coordinate) : base
	(
		new SpatialWithCoordinates(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}