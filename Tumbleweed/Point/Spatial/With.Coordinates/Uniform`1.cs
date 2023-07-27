using Point = Tumbleweed.Point.Spatial;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Point.Spatial.With.Coordinates;

public sealed class Uniform<T> : Point::Envelope<T>
{
	public Uniform(T coordinate) : this
	(
		new Scalar::Of.Value<T>(coordinate)
	)
	{
	}
	
	public Uniform(Scalar::Any<T> coordinate) : base
	(
		new Point::With.Coordinates.Unique<T>(
			coordinate,
			coordinate,
			coordinate)
	)
	{
	}
}