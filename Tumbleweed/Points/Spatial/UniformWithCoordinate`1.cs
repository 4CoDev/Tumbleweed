using Tumbleweed.Scalars;

namespace Tumbleweed.Points.Spatial;

public sealed class UniformWithCoordinate<T> : SpatialEnvelope<T>
{
	public UniformWithCoordinate(T coordinate) : this
	(
		new ScalarValue<T>(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate(IScalar<T> coordinate) : base
	(
		new SpatialWithCoordinates<T>(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}