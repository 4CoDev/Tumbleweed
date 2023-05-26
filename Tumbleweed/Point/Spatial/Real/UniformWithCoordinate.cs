using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.Real;

public sealed class UniformWithCoordinate :
	PointEnvelope<IReal>
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
		new PointWithCoordinates(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}