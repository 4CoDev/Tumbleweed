using Tumbleweed.Scalar;

namespace Tumbleweed.Spatial.Point;

public sealed class UniformWithCoordinate<T> : PointEnvelope<T>
{
	public UniformWithCoordinate(T coordinate) : this
	(
		new ScalarValue<T>(coordinate)
	)
	{
	}
	
	public UniformWithCoordinate(IScalar<T> coordinate) : base
	(
		new PointWithCoordinates<T>(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}