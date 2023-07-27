using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Point.Spatial.Coordinate;

public sealed class Enumerable<T> : Enumerable::Envelope<T>
{
	public Enumerable(Point::Any<T> point) : base
	(
		new Enumerable::From.Array<T>(
			point.X,
			point.Y,
			point.Z)
	)
	{
	}
}