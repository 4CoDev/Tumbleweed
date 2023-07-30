using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using Point = Tumbleweed.Point.Spatial;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.With.Coordinates;

public sealed class Uniform<T> : Point::Envelope<T>
{
	public Uniform(T coordinate) : this
	(
		new Value<T>(coordinate)
	)
	{
	}
	
	public Uniform(Tumbleweed.Scalar.Immutable.Any<T> coordinate) : base
	(
		new Point::With.Coordinates.Unique<T>(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}